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
using NativeWifi;

namespace ColourCool
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {       
        public MainWindow()
        {            
            InitializeComponent();
            ConnectionDetails.Content = new ConnectionPage();
        }


        private void next_Click(object sender, RoutedEventArgs e)
        {
            Button input = (Button)sender;
            input.Visibility = Visibility.Hidden;           
            ConnectionDetails.Content = new ColourCoolDevice();
            connectButton.Visibility = Visibility.Visible;

            String wifiName = (String)Application.Current.Resources["ApplicationScopeSSID"];
            String wifiPassword = (String)Application.Current.Resources["ApplicationScope"];
            Console.WriteLine("Wifi Name: "+ wifiName);
            Console.WriteLine("Wifi Password: " + wifiPassword);
        }

        private void connect_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Sending data to ColourCool");        
        }
    }
}
