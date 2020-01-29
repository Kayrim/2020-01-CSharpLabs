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
            
        }

        private void ListRabbits_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ListRabbits.SelectedItem != null)
            {
                rb = (rabbitTable)ListRabbits.SelectedItem;
                TextboxRabbitName.Text = rb.RabbitName.ToString();
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
    }
}
