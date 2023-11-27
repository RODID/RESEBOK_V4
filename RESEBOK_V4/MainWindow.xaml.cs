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
        public MainWindow()
        {
            InitializeComponent();
        }

        public void Login_Click(object sender, RoutedEventArgs e)
        {
            string enterdUsername = Username.Text;
            bool LoginSucces = false;
            int loginCount = 3;

            while (LoginSucces) 
            {
               if (LoginSucces) 
                {
                    MessageBox.Show("Invalid username");
                    loginCount--;
                }
                if (loginCount < 0)
                {
                    MessageBox.Show("are u under stress? this been thre times!");
                    loginCount = 3;
                }
            }
            if (enterdUsername == "ChupaCabra")
            {
                 ListWindow listWindow = new ListWindow();
                 listWindow.Show();

                 this.Hide();
            }
            

            
            

        }
    }
}
