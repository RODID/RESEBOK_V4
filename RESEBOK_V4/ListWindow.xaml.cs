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

        public void InitializeDestinations()
        {
            listOfDestinations = new List<Destinations>();

            //förinställda destinationer haha
            ListDestination.Items.Add(new Destination { CityName = "Spain", Year = 1975, Month = 07, Day = 17 });
            ListDestination.Items.Add(new Destination{ CityName = "Stockholm", Year = 1981, Month = 12, Day = 29});
            ListDestination.Items.Add(new Destination { CityName = "Bali", Year = 1972, Month = 04, Day = 13});

            //Binding the list to the ListBox
            ListDestination.ItemsSource = listOfDestinations;

        }

        private void AddDestination_Click(object sender, RoutedEventArgs e)
        {
            //Värdet på TextBoxes
            string city = AddCity.Text;
            int year = int.Parse(AddYear.Text);
            int month = int.Parse(AddMonth.Text);
            int day = int.Parse(AddDay.Text);

            //skapar en ny destination och lägger till den i listan
            Destination newDestination = new Destination { CityName = city, Year = year, Month = month, Day = day };
            listOfDestinations.Add(newDestination);

            // rensar efter man har använt funktionen
            AddCity.Clear();
            AddYear.Clear();
            AddMonth.Clear();
            AddDay.Clear();




        }

        private void AddCity_TouchEnter(object sender, TouchEventArgs e)
        {

        }
    }
}
