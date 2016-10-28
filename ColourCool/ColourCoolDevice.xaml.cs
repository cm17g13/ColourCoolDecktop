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
        public ColourCoolDevice()
        {
            InitializeComponent();
            cmbColors.ItemsSource = typeof(Colors).GetProperties();
            
        }

        private void companyID_TextInput(object sender, TextChangedEventArgs e)
        {
            Object guanda = cmbColors.SelectedItem;
            Console.WriteLine("What am I? " + guanda.ToString());

            string dop = companyID.Text;
            Console.WriteLine("What am I? " + dop);
        }
    }
}
