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

namespace RESEBOK_V4
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int loginCount = 3;

        private readonly ListWindow listWindow;


        public MainWindow()
        {
            InitializeComponent();
            this.listWindow = listWindow;

        }

        public async void Login_Click(object sender, RoutedEventArgs e)
        {
            string enteredUsername = Username.Text;

            if (enteredUsername == "ChupaCabra")
            {
                ListWindow listWindow = new ListWindow(this);
                listWindow.Show();
                Username.Clear();
                this.Hide();
            }
            else
            {
                loginCount--;

                if (loginCount == 1)
                {
                    SetupText.Text = $"Are you okay?";
                }
                else if (loginCount == 0)
                {
                    SetupText.Text = $"Emergency Shut down";
                    await Task.Delay(3000);
                    Close();
                }
                
            }
        }
        private void GoBack_Click(object sender, RoutedEventArgs e)
        {
            
        }

    }
}
