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

namespace ColourCool
{
    /// <summary>
    /// Interaction logic for ColourCool.xaml
    /// </summary>
    public partial class ColourCoolDevice : Page
    {
        public String[] arr;
        Color red = Color.FromRgb(255, 0, 0);
        Color green = Color.FromRgb(0, 255, 0);
        Color blue = Color.FromRgb(0, 0, 255);
        Color yellow = Color.FromRgb(255, 255, 0);
        Color magneta = Color.FromRgb(255, 0, 255);
        Color cyan = Color.FromRgb(0, 255, 255);
        Color white = Color.FromRgb(255, 255, 255);

        public ColourCoolDevice()
        {

            arr = new String[7];
            InitializeComponent();
            arr[0] = "red";
            arr[1] = "green";
            arr[2] = "blue";
            arr[3] = "yellow";
            arr[4] = "magneta";
            arr[5] = "cyan";
            arr[6] = "white";


            //cmbColors.ItemsSource = arr;
            //cmbColors.ItemsSource = typeof(Colors).GetProperties();

        }

        private void companyID_TextInput(object sender, TextChangedEventArgs e)
        {
            Object guanda = cmbColors.SelectedItem;
            Console.WriteLine("What am I? " + guanda.ToString());
            Application.Current.Resources["ApplicationScopeColor"] = guanda.ToString();

            string dop = companyID.Text;
            Console.WriteLine("What am I? " + dop);
            Application.Current.Resources["ApplicationScopeID"] = dop;
        }
    }
}
