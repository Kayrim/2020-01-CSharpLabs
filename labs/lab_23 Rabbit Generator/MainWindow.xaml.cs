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

        static List<Rabbit> rabbitList = new List<Rabbit>();
        static Rabbit firstRab = new Rabbit();
        public MainWindow()
        {
            InitializeComponent();
            firstRab.Age = 0;
            firstRab.name = "Rabbit" + 1;
            rabbitList.Add(firstRab);
        }

        private void task1Button_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                var r = new Rabbit();
                r.name = "Rabbit " + i;
                rabbitList.Add(r);
                list1.Items.Add(r.name);
               
                
            }
        }

        private void List1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void AgeRabbits_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                var r = new Rabbit();
                r.name = "Rabbit " + i;
                r.Age = 0;
                rabbitList.Add(r);
                
                


            }
            for (int i = 0; i < 100; i++)
            {


                foreach (var item in rabbitList)
                {
                    item.Age++;
                }
            }
            foreach (var x in rabbitList)
            {
                list2.Items.Add(x.name + " " + x.Age);
            }

        }

        private void BreedRabbits_Click(object sender, RoutedEventArgs e)
        {
            //var firstRab = new Rabbit();
            list3.Items.Clear();
            
            

            foreach (var i in rabbitList)
            {
                i.Age++;
            }
            foreach (var x in rabbitList.ToArray())
            {
                var rbt = new Rabbit();
                rbt.Age = 0;
                rbt.name = "Rabbit "+rabbitList.Count;
                rabbitList.Add(rbt);
            }
            foreach (var i in rabbitList)
            {
                list3.Items.Add(i.name + " " + i.Age);
            }


        }

        private void AgeRestrict_Click(object sender, RoutedEventArgs e)
        {

        }
    }
    class Rabbit
    {
        public int RabbitID { get; set; }
        public string name { get; set; }
        public int Age { get; set; }
    }
}

