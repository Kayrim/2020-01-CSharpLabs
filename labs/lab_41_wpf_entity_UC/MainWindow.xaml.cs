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

namespace lab_41_wpf_entity_UC
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<User> users = new List<User>();
        List<Category> categories = new List<Category>();
        User user = new User();
        bool editUser = false;
        Category category = new Category();

        public MainWindow()
        {
            InitializeComponent();
            Initialise();
            DisplayUsers();
        }

        void Initialise()
        {
            
        }

        void DisplayUsers()
        {
            using (var db = new UserCategories())
            {
                users = db.Users.ToList();
                categories = db.Categories.ToList();
            }

            ListBox01.ItemsSource = users;
            ListBox02.ItemsSource = categories;
            ListBox01.DisplayMemberPath = "UserName";
            ListBox02.DisplayMemberPath = "CategoryName";
            ComboBox.ItemsSource = categories;
            ComboBox.DisplayMemberPath = "CategoryName";
        }

        private void ListBox01_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ListBox01.SelectedItem != null)
            {
                user = (User)ListBox01.SelectedItem;

                ComboBox.Text = user.Category.CategoryName;

            }
        }

        private void ListBox01_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            editUser = true;

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            category = (Category)ComboBox.SelectedItem;
            if (editUser && user != null)
            {
                using (var db = new UserCategories())
                {
                    var userToUpdate = db.Users.Find(user.UserID);
                    userToUpdate.CategoryID = category.CategoryID;
                    db.SaveChanges();

                    ListBox01.ItemsSource = null;
                    ListBox02.ItemsSource = null;
                    
                    users = db.Users.ToList();
                    categories = db.Categories.ToList();

                    ListBox01.ItemsSource = users;
                    ListBox02.ItemsSource = categories;
                    editUser = false;

                }
                
            }
        }
    }
}
