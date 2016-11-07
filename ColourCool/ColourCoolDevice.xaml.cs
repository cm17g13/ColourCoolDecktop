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
        public String[] arr = new String[7];
        Color red = Color.FromRgb(255, 0, 0);
        Color green = Color.FromRgb(0, 255, 0);
        Color blue = Color.FromRgb(0, 0, 255);
        Color yellow = Color.FromRgb(255, 255, 0);
        Color magneta = Color.FromRgb(255, 0, 255);
        Color cyan = Color.FromRgb(0, 255, 255);
        Color white = Color.FromRgb(255, 255, 255);


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
