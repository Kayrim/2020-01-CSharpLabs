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

namespace lab_34_rabbit_advanced
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static List<rabbitTable> rabbits = new List<rabbitTable>();
        static rabbitTable rb = new rabbitTable();
        public MainWindow()
        {
            InitializeComponent();
            Initialize();
            
        }

        void Initialize()
        {
            using (var db = new rabbitDatabaseEntities())
            {
                rabbits = db.rabbitTables.ToList();   
            }
            TextboxRabbitName.IsReadOnly = true;
            EditRabbitButton.IsEnabled = false;
        }

        private void ListRabbits_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ListRabbits.SelectedItem != null)
            {
                rb = (rabbitTable)ListRabbits.SelectedItem;
                TextboxRabbitName.Text = rb.RabbitName.ToString();
                // setting the textbox to read only so it cant be edited
                TextboxRabbitName.IsReadOnly = true;
                EditRabbitButton.IsEnabled = true;
            }
            
        }

        private void ShowRabbits_Click(object sender, RoutedEventArgs e)
        {
            ListRabbits.ItemsSource = rabbits;
        }

        private void ListRabbits_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (rb!=null)
            {
                using (var db = new rabbitDatabaseEntities())
                {
                    var rabbitToDelete = db.rabbitTables.Find(rb.RabbitID);
                    var result = MessageBox.Show($"Delete Rabbit {rb.RabbitID} are you sure?","Warning", MessageBoxButton.YesNoCancel);
                    if (result == MessageBoxResult.Yes)
                    {
                        db.rabbitTables.Remove(rabbitToDelete);
                        db.SaveChanges();
                        ListRabbits.ItemsSource = null;
                        rabbits = db.rabbitTables.ToList();
                        ListRabbits.ItemsSource = rabbits;

                    }
                    

                }
            }
        }

        private void AddRabbit_Click(object sender, RoutedEventArgs e)
        {
            if (AddRabbit.Content.ToString() == "Add a Rabbit")
            {
                TextboxRabbitName.IsReadOnly = false;
                TextboxRabbitName.Text = "";
             

                AddRabbit.Content = "Save Changes";

            }else{

                if (TextboxRabbitName.Text.Length > 0)
                {
                    using (var db = new rabbitDatabaseEntities())
                    {
                        var rabbitToAdd = new rabbitTable()
                        {
                            RabbitName = TextboxRabbitName.Text
                        };


                        db.rabbitTables.Add(rabbitToAdd);
                        db.SaveChanges();
                        ListRabbits.ItemsSource = null;
                        rabbits = db.rabbitTables.ToList();
                        ListRabbits.ItemsSource = rabbits;




                    }
                    TextboxRabbitName.Text = "";
                }
                
                AddRabbit.Content = "Add a Rabbit";
            }

            
        }

        private void ListRabbits_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void EditRabbitButton_Click(object sender, RoutedEventArgs e)
        {
            if (rb!=null)
            {
                if (EditRabbitButton.Content.ToString()== "Edit")
                {
                    EditRabbitButton.Content = "Save";
                    var bc = new BrushConverter();
                    TextboxRabbitName.Background = (Brush)bc.ConvertFrom("#F0F9D9");
                    TextboxRabbitName.IsReadOnly = false;
                }
                else
                {
                    if (TextboxRabbitName.Text.Length>0)
                    {
                        using (var db = new rabbitDatabaseEntities())
                        {
                            var rabbitToUpdate = db.rabbitTables.Find(rb.RabbitID);
                            //Int32.TryParse(textboxrabbitage.text.ToString(), out int rabbitAge);
                            rabbitToUpdate.RabbitName = TextboxRabbitName.Text;
                            // rabbitToUpdate.RabbitAge = rabbitAge;
                            db.SaveChanges();
                            ListRabbits.ItemsSource = null;
                            rabbits = db.rabbitTables.ToList();
                            ListRabbits.ItemsSource = rabbits;

                        }
                        
                    }
                    EditRabbitButton.Content = "Edit";
                }
            }
        }
    }
}
