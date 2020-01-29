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

namespace lab_23_Rabbit_Generator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        static List<Rabbit> rabbitList1 = new List<Rabbit>();
        static List<Rabbit> rabbitList2 = new List<Rabbit>();
        static List<Rabbit> rabbitList3 = new List<Rabbit>();
        static List<Rabbit> rabbitList4 = new List<Rabbit>();
        
        public MainWindow()
        {
            InitializeComponent();

            Rabbit firstRab = new Rabbit();
            Rabbit firstRab2 = new Rabbit();
            firstRab.Age = 0;
            firstRab2.Age = 0;
            firstRab.name = "Rabbit ID: " + 1;
            firstRab2.name = "Rabbit ID: " + 1;
            rabbitList3.Add(firstRab);
            rabbitList4.Add(firstRab2);
            
        }

        private void task1Button_Click(object sender, RoutedEventArgs e)
        {
            list1.Items.Clear();

            for (int i = 1; i <= 100; i++)
            {
                var r = new Rabbit();
                r.name = "Rabbit ID: " + i;
                rabbitList1.Add(r);
                list1.Items.Add(r.name);
               
                
            }
        }

        private void List1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void AgeRabbits_Click(object sender, RoutedEventArgs e)
        {
            list2.Items.Clear();
            if (rabbitList2.Count < 100)
            {
                for (int i = 1; i <= 100; i++)
                {
                    var r = new Rabbit();
                    r.name = "Rabbit ID: " + i;
                    r.Age = 0;
                    rabbitList2.Add(r);
                                                         
                }
            }
            for (int i = 0; i < 100; i++)
            {


                foreach (var item in rabbitList2)
                {
                    item.Age++;
                }

                
            }
            foreach (var x in rabbitList2)
            {
                list2.Items.Add(x.name + " Age: " + x.Age);
                
            }

        }

        private void BreedRabbits_Click(object sender, RoutedEventArgs e)
        {
            //var firstRab = new Rabbit();
            list3.Items.Clear();
            
            

            foreach (var i in rabbitList3)
            {
                i.Age++;
            }
            foreach (var x in rabbitList3.ToArray())
            {
                var rbt = new Rabbit();
                rbt.Age = 0;
                rbt.name = "Rabbit ID: " + (rabbitList3.Count+1);
                rabbitList3.Add(rbt);
            }
            foreach (var i in rabbitList3)
            {
                list3.Items.Add(i.name + " Age: " + i.Age);
            }


        }

        private void AgeRestrict_Click(object sender, RoutedEventArgs e)
        {
            list4.Items.Clear();



            foreach (var i in rabbitList4.ToArray())
            {
                i.Age++;

            }
            foreach (var z in rabbitList4.ToArray())
            {
                if (z.Age >= 3)
                {



                    var rbt = new Rabbit();
                    rbt.Age = 0;
                    rbt.name = "Rabbit ID: " + (rabbitList4.Count + 1);
                    rabbitList4.Add(rbt);
                    //break;

                    //foreach (var y in rabbitList2)
                    //{
                    //    list4.Items.Add(y.name + " Age: " + y.Age);
                    //}
                }
            }
            foreach (var y in rabbitList4)
            {
                list4.Items.Add(y.name + " Age: " + y.Age);
            }


        } 

                
            
            
        }
    }
    class Rabbit
    {
        public int RabbitID { get; set; }
        public string name { get; set; }
        public int Age { get; set; }
    }


