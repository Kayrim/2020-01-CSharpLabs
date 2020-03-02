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
using System.Windows.Shapes; // CALL LIBRARY

namespace lab_33b_rabbits
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static List<Rabbit> rabbits = new List<Rabbit>();
        static Rabbit rabbit = new Rabbit();
        public MainWindow()
        {
            InitializeComponent();
            Initialize();
        }

        void Initialize()
        {
            //var db = new RabbitDatabaseEntities(); // potentially messy

            // CLEAN CODE WRAPPER - BETTER
            using (var db = new RabbitDatabaseEntities()) {
                rabbits = db.Rabbits.ToList();
            }

            // show data as read only
            TextBoxRabbitId.IsReadOnly = true;
            TextBoxRabbitName.IsReadOnly = true;
            TextBoxRabbitAge.IsReadOnly = true;
            // edit button is read only
            ButtonEdit.IsEnabled = false;
        }

        private void ButtonShowRabbits_Click(object sender, RoutedEventArgs e)
        {
            // get list rabbits and show on screen
            // screen      bind to       list of rabbits
            ListBoxRabbits.ItemsSource = rabbits;  // bind listbox to list
            ListBoxRabbits.DisplayMemberPath = "RabbitName";

            //foreach (var rabbit in rabbits)
            //{
            //    ListBoxRabbits.Items.Add(rabbit.RabbitName);
            //}

            
            ListViewRabbits.ItemsSource = rabbits;

        }

        private void ListBoxRabbits_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ListViewRabbits_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ListViewRabbits.SelectedItem != null)
            {
                // select rabbit by casting to Rabbit type the object select in ListView
                rabbit = (Rabbit)ListViewRabbits.SelectedItem;
                TextBoxRabbitId.Text = rabbit.RabbitId.ToString();
                TextBoxRabbitName.Text = rabbit.RabbitName;
                TextBoxRabbitAge.Text = rabbit.Age.ToString();
            }

            // show data as read only
            TextBoxRabbitId.IsReadOnly = true;
            TextBoxRabbitName.IsReadOnly = true;
            TextBoxRabbitAge.IsReadOnly = true;
            // set edit button to active
            ButtonEdit.IsEnabled = true;

        }

        private void ListViewRabbits_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            // must have selected a rabbit
            if (rabbit != null)
            {
                // only open database when needed
                using (var db = new RabbitDatabaseEntities())
                {
                    // find in the database the rabbit which has an ID the same as the selected rabbit
                    var rabbitToDelete = db.Rabbits.Find(rabbit.RabbitId);
                    var result = MessageBox.Show($"Delete Rabbit {rabbit.RabbitId}? Are you sure?",
                        "Rabbit Database",MessageBoxButton.OKCancel);
                    if(result == MessageBoxResult.OK)
                    {
                        db.Rabbits.Remove(rabbitToDelete);
                        db.SaveChanges();
                        ListViewRabbits.ItemsSource = null; // reset to zero
                        rabbits = db.Rabbits.ToList(); // refresh rabbits from database
                        ListViewRabbits.ItemsSource = rabbits; // refresh view
                    }
                }
            }
        }

        private void ButtonAddRabbit_Click(object sender, RoutedEventArgs e)
        {
            if (ButtonAddRabbit.Content.ToString() == "Add Rabbit")
            {
                // text boxes now become editable
                TextBoxRabbitName.IsReadOnly = false;
                TextBoxRabbitAge.IsReadOnly = false;
                // clear all text boxes
                TextBoxRabbitId.Text = "";
                TextBoxRabbitName.Text = "";
                TextBoxRabbitAge.Text = "";

                ButtonAddRabbit.Content = "Save";
            }
            else
            {
                // save new rabbit to database
                if (TextBoxRabbitName.Text.Length>0)
                {
                    Int32.TryParse(TextBoxRabbitAge.Text, out int rabbitage);

                    var rabbitToAdd = new Rabbit()
                    {
                        RabbitName = TextBoxRabbitName.Text,
                        Age = rabbitage
                    };
                    // get database into memory (db = local computer copy of database)
                    using (var db = new RabbitDatabaseEntities()) {
                        db.Rabbits.Add(rabbitToAdd);
                        db.SaveChanges();
                        
                        // update list
                        // firstly set to null
                        ListViewRabbits.ItemsSource = null;
                        // secondsly re-read rabbits afresh from database
                        rabbits = db.Rabbits.ToList();
                        ListViewRabbits.ItemsSource = rabbits;
                    }
                }
                ButtonAddRabbit.Content = "Add Rabbit";
            }
        }


        private void ListViewRabbits_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void ButtonEdit_Click(object sender, RoutedEventArgs e)
        {
            // check we have got a rabbit
            if(rabbit != null)
            {
                if (ButtonEdit.Content.ToString() == "Edit")
                {
                    // shade the boxes so it's clear we are editing
                    var shader = new SolidColorBrush(Color.FromRgb(249,238,169));
                    TextBoxRabbitName.Background = shader;
                    TextBoxRabbitAge.Background = shader;
                    // make boxes editable
                    TextBoxRabbitName.IsReadOnly = false;
                    TextBoxRabbitAge.IsReadOnly = false;
                    ButtonEdit.Content = "Save";
                }
                // user hits 'save'
                else
                {
                    // check name not null
                    if (TextBoxRabbitName.Text.Length > 0)
                    {
                        // find matching rabbit in database
                        using (var db = new RabbitDatabaseEntities())
                        {
                            Int32.TryParse(TextBoxRabbitAge.Text.ToString(), out int rabbitage);
                            var rabbitToUpdate = db.Rabbits.Find(rabbit.RabbitId);
                            rabbitToUpdate.RabbitName = TextBoxRabbitName.Text;
                            rabbitToUpdate.Age = rabbitage;
                            // update database
                            db.SaveChanges();
                            // update list
                            ListViewRabbits.ItemsSource = null;
                            rabbits = db.Rabbits.ToList();
                            ListViewRabbits.ItemsSource = rabbits;
                        }
                    }
                    // put back to default
                    TextBoxRabbitName.Background = Brushes.White;
                    TextBoxRabbitAge.Background = Brushes.White;
                    TextBoxRabbitName.IsReadOnly = true;
                    TextBoxRabbitAge.IsReadOnly = true;
                    ButtonEdit.Content = "Edit";
                }
            }
        }
    }
}
