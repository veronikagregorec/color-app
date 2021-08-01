using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Pravokotnik
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

        private void sldRdeča_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Mešaj();
        }
        private void Mešaj()
        {
            byte r = (byte)sldRdeča.Value;
            byte g = (byte)sldZelena.Value;
            byte b = (byte)sldModra.Value;
            SolidColorBrush br = new SolidColorBrush(Color.FromRgb(r, g, b));
            p.Fill = br;
        }

        private void sldZelena_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Mešaj();
        }

        private void sldModra_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Mešaj();
        }


        private void TxtB_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtB.Text = Regex.Replace(txtB.Text, "[^0-9]+", "");
        }

        private void TxtG_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtG.Text = Regex.Replace(txtG.Text, "[^0-9]+", "");
        }

        private void TxtR_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtR.Text = Regex.Replace(txtR.Text, "[^0-9]+", "");
        }
    }
}
