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

namespace Rabbits
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static List<Rabbit> rabbits = new List<Rabbit>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button100Rabbits_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 100; i++) {
                var rabbit = new Rabbit();
                rabbit.RabbitName = "Rabbit" + i;
                rabbits.Add(rabbit); // add to list

            }

            // print rabbits
            foreach (var rabbit in rabbits)
            {
                ListBox100Rabbits.Items.Add(rabbit.RabbitName); // add STRING NAME
            }


        }



        private void ButtonAgeRabbits100Times_Click(object sender, RoutedEventArgs e)
        {
            // generate 100 rabbits
            for(int i = 0; i < 100; i++)
            {
                var rabbit = new Rabbit();
                rabbit.Age = 0;
                rabbit.RabbitName = "Rabbit" + i;
                // add new rabbit to list
                rabbits.Add(rabbit);
            }

            // EASY VERSION (year one)
            // JUST DO A FOREACH LOOP, GET EVERY RABBIT, AND ADD 1 TO THE AGE OF EVERY RABBIT

            foreach(var rabbit in rabbits)
            {
                rabbit.Age++;
            }

            // year two

            foreach (var rabbit in rabbits)
            {
                rabbit.Age++;
            }

            // year three

            foreach (var rabbit in rabbits)
            {
                rabbit.Age++;
            }

            for (int i = 0; i < 97; i++)
            {
                foreach (var rabbit in rabbits)
                {
                    rabbit.Age++;
                }
            }
         

            // print rabbits
            foreach (var rabbit in rabbits)
            {
                ListBoxAgeRabbits100Times.Items.Add(rabbit.RabbitName + " " + rabbit.Age); // add STRING NAME
            }











            // age rabbits 100 times
            // loop 100 times 
            // each loop, take each rabbit and age 1 year


            for (int i=0; i<100; i++)
            {
                
            }

        }
    }

    class Rabbit
    {
        public string RabbitName { get; set; }
        public int Age { get; set; }
    }
}
