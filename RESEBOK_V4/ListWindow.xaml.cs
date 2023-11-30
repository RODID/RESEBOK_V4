﻿using System;
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
using System.IO;
using System.Globalization;
using CsvHelper;
using RESEBOK_V4;

namespace RESEBOK_V4
{
    public partial class ListWindow : Window
    {
        private readonly CsvFileManager csvFileManager = new CsvFileManager("Destinations.csv");
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

                csvFileManager.SaveDestinations(listOfDestinations);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An Error Occurred: {"sett correct information"}", "error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void AddCity_TouchEnter(object sender, TouchEventArgs e)
        {

        }
    }
}
