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
using 

namespace RESEBOK_V4
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int loginCount = 3;


        public MainWindow()
        {
            InitializeComponent();
        }

        public void Login_Click(object sender, RoutedEventArgs e)
        {
            string enteredUsername = Username.Text;

            if (enteredUsername == "ChupaCabra")
            {
                ListWindow listWindow = new ListWindow();
                listWindow.Show();
                this.Hide();
            }
            else
            {
                loginCount--;

                if(loginCount > 0)
                {
                    MessageBox.Show($"Invalid username. {loginCount} attampts remaining.", "Login Failed", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else
                {
                    MessageBox.Show("You have exceeded the maximum number of login attempts. Please come back later.", "Login Failed", MessageBoxButton.OK, MessageBoxImage.Error);

                    Close();
                }
            }
            

            
            

        }
    }
}
