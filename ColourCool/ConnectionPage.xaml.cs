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
    /// Interaction logic for ConnectionPage.xaml
    /// </summary>
    public partial class ConnectionPage : Page
    {
        //Variables
        private List<WifiDetails> wifi = new List<WifiDetails>();
        private string wifiName;
        private string encryptionLevel;
        private string wifiStrength;
        public string wifiPassword;

        public partial class WifiDetails
        {
            public string SSID { get; set; }
            public string Encryption { get; set; }
            public string Strength { get; set; }
        }

        public ConnectionPage()
        {
            InitializeComponent();
            getWifiList();
        }

        private void getWifiList()
        {
            //Creates a list to save the wifi collected
            

            //Requests the Internet Connectors Ethernet and WiFi
            WlanClient client = new WlanClient();
            foreach (WlanClient.WlanInterface wlanIface in client.Interfaces)
            {
                //Finds available WiFi
                Wlan.WlanAvailableNetwork[] networks = wlanIface.GetAvailableNetworkList(0);
                foreach (Wlan.WlanAvailableNetwork network in networks)
                {
                    //Gather wifi details
                    Wlan.Dot11Ssid ssid = network.dot11Ssid;
                    string networkName = Encoding.ASCII.GetString(ssid.SSID, 0, (int)ssid.SSIDLength);

                    //Create a wifi object and add to list            
                    wifi.Add(new WifiDetails() { SSID = networkName, Encryption = network.dot11DefaultCipherAlgorithm.ToString(), Strength = network.wlanSignalQuality + "%" });

                    //ListViewItem item = new ListViewItem(networkName);
                    //item.SubItems.Add(network.dot11DefaultCipherAlgorithm.ToString());
                    //item.SubItems.Add(network.wlanSignalQuality + "%");
                    //lstNetworks.Items.Add(item);                

                }

                //Adds all the wifi to the list created
                lstNetworks.ItemsSource = wifi;
            }            
        }

        private void lstNetworks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            WifiDetails wifiDetails = (WifiDetails)lstNetworks.SelectedItems[0];
            wifiName = wifiDetails.SSID;
            encryptionLevel = wifiDetails.Encryption;
            wifiStrength = wifiDetails.Strength;

            Console.WriteLine(wifiDetails.SSID);

            //Used to set the variable application wide = name
            Application.Current.Resources["ApplicationScopeSSID"] = wifiName;
        }

        private void passwordBox_TextInput(object sender, TextChangedEventArgs e)
        {
            wifiPassword = passwordBox.Text;
            Application.Current.Resources["ApplicationScope"] = wifiPassword;
            Console.WriteLine(wifiPassword);
        }
    }
}
