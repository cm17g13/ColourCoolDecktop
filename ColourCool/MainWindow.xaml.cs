using System;
using System.IO;
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
        }

        private void connect_Click(object sender, RoutedEventArgs e)
        {
            String wifiName = (String)Application.Current.Resources["ApplicationScopeSSID"];
            String wifiPassword = (String)Application.Current.Resources["ApplicationScopePassword"];
            String deviceColor = (String)Application.Current.Resources["ApplicationScopeColor"];
            String deviceID = (String)Application.Current.Resources["ApplicationScopeID"];
            Console.WriteLine("Wifi Name: " + wifiName);
            Console.WriteLine("Wifi Password: " + wifiPassword);
            Console.WriteLine("Device LED Color: " + deviceColor);
            Console.WriteLine("Device UserID: " + deviceID);

            // Create a string array with the lines of text
            string[] lines = { "#define SSID " + wifiName, "#define PASS " + wifiPassword, "#define COL " + deviceColor, "#define USERID " + deviceID };

            // Set a variable to the My Documents path.
            string myDocPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // Write the string array to a new file named "WriteLines.txt".
            using (StreamWriter outputFile = new StreamWriter(myDocPath + @"\wifiInfo.txt"))
            {
                foreach (string line in lines)
                    outputFile.WriteLine(line);
            }

            Console.WriteLine("Sending data to ColourCool");        
        }
    }
}
