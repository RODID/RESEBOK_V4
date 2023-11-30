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

        public List<Destination> listOfDestinations;
        public ListWindow()
        {
            InitializeComponent();
            InitializeDestinations();
        }

        public void InitializeDestinations()
        {
            listOfDestinations = new List<Destination>();

            ListDestination.ItemsSource = listOfDestinations;

            ListDestination.Background = Brushes.White;
            new Destination { CityName = "Spain", Year = 1999, Month = 12, Day = 12 };
            new Destination { CityName = "Schewiz", Year = 1996, Month = 02, Day = 15 };
            new Destination { CityName = "Serbia", Year = 1976, Month = 05, Day = 17 };

        }

        private void AddDestination_Click(object sender, RoutedEventArgs e)
        {
            try 
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
            catch (Exception ex)
            {
                MessageBox.Show($"An Error Occurred: {"set correct information"}", "error", MessageBoxButton.OK, MessageBoxImage.Error);
            }




        }

        private void AddCity_TouchEnter(object sender, TouchEventArgs e)
        {

        }
    }
}
