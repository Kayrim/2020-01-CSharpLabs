using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lab_44_WPF_Entity_Users_Categories
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<User> users = new List<User>();
        List<Category> categories = new List<Category>();
        User user = new User();
        Category category = new Category();
        bool EditUser = false;

        public MainWindow()
        {
            InitializeComponent();
            Initialise();
        }
        void Initialise()
        {
            using(var db = new UsersCategoriesModel())
            {
                users = db.Users.ToList();
                categories = db.Categories.ToList();
            }
            ListBox01.ItemsSource = users;
            ListBox02.ItemsSource = categories;
            ListBox01.DisplayMemberPath = "UserName";
            ListBox02.DisplayMemberPath = "CategoryName";
            ComboBoxCategories.ItemsSource = categories;
            ComboBoxCategories.DisplayMemberPath = "CategoryName";
            ComboBoxCategories.IsReadOnly = true;
            ComboBoxCategories.AllowDrop = false;
        }

        private void ListBox01_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ListBox01.SelectedItem != null)
            {
                user = (User)ListBox01.SelectedItem;
               
               
                // display user category in combo
                ComboBoxCategories.Text = user.Category.CategoryName;
               
              
            }

        }

        private void ListBox02_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ListBox01_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            // not working 
            ListBox01.Background = Brushes.Orange;
            // set boolean EditUser = true
            EditUser = true;

        }

        private void ListBox01_MouseDoubleClick_1(object sender, MouseButtonEventArgs e)
        {

        }

        private void ComboBoxCategories_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboBoxCategories.SelectedItem == null)
            {
                return;
            }
            category = (Category)ComboBoxCategories.SelectedItem;
            if (EditUser && user != null)
            {
                using (var db = new UsersCategoriesModel())
                {
                    var userToUpdate = db.Users.Find(user.UserId);
                    // update category
                    userToUpdate.CategoryId = category.CategoryId;
                    db.SaveChanges();
                    // clear list box
                    ListBox01.ItemsSource = null;
                    // re-display list box
                    users = db.Users.ToList();
                    ListBox01.ItemsSource = users;
                    MessageBox.Show($"User {user.UserName} category changed to " +
                        $"{userToUpdate.Category.CategoryName}");
                    // also update second categories
                    ListBox02.ItemsSource = null;
                    categories = db.Categories.ToList();
                    ListBox02.ItemsSource = categories;
                    EditUser = false;
                    ListBox01.Background = Brushes.White;
                }
            }
        }
    }
}
