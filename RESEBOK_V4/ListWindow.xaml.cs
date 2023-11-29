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
using System.Windows.Shapes;

namespace RESEBOK_V4
{
    /// <summary>
    /// Interaction logic for ListWindow.xaml
    /// </summary>
    public partial class ListWindow : Window
    {

        public List<Destinations> listOfDestinations;
        public ListWindow()
        {
            InitializeComponent();
            InitializeDestinations();
        }

        public ListWindow(string cityName, int year, int month, int day)
        {
            string CityName = cityName;
            int Year = year;
            int Month = month;
            int Day = day;
            string Notes = notes;
        }

        public string cityName { get; set; }
        public int year { get; set; }   
        public int month { get; set; }
        public int day { get; set; }
        public string notes { get; set; }
        public void InitializeDestinations()
        {
            ListDestination.Items.Add("Spain" + " - " + 1975 + " - " + 07 + " - " + 17);           
            ListDestination.Items.Add("Stockholm" + " - " + 1981 + " - " + 12 + " - " + 29);
            ListDestination.Items.Add("Bali" + " - " + 1975 + " - " + 07 + " - " + 17);

        }

        private void AddDestination_Click(object sender, RoutedEventArgs e)
        {
            new List<Destinations>();

        }
    }
}
