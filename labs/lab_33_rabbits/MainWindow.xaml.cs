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

namespace lab_33_rabbits
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
            Initialize();
        }

        void Initialize()
        {

            using (var db = new RabbitDatabaseEntities())
            {
                rabbits = db.Rabbits.ToList();
            }
            // display rabbits
        }

        private void ListViewRabbits_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
