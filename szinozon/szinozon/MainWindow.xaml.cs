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

namespace szinozon
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

        private void Szinkeveres()
        {
            rctTeglalap.Fill = new SolidColorBrush(Color.FromRgb(Convert.ToByte(sliPiros.Value), Convert.ToByte(sliZold.Value), Convert.ToByte(sliKek.Value)));
        }



        private void sliPiros_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Szinkeveres();
            lbPirosAdat.Content = Convert.ToByte(sliPiros.Value);

        }

        private void sliZold_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Szinkeveres();
            lbZoldAdat.Content = Convert.ToByte(sliZold.Value);
        }

        private void sliKek_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Szinkeveres();
            lbKekAdat.Content = Convert.ToByte(sliKek.Value);
        }

        private void btnRogzit_Click(object sender, RoutedEventArgs e)
        {
            string szinadatok = ($"{Convert.ToByte(sliPiros.Value)};{Convert.ToByte(sliZold.Value)};{Convert.ToByte(sliKek.Value)}");
            
            //string[] tagok = lboxLista.SelectedItem.ToString().Split(';');
           
            lboxLista.Items.Add(szinadatok);
            
            
        }

        private void btnTorol_Click(object sender, RoutedEventArgs e)
        {
            if (lboxLista.SelectedIndex>=0)
            {
                lboxLista.Items.RemoveAt(lboxLista.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Nem választott ki elemet");
            }
            
        }

        private void btnUrites_Click(object sender, RoutedEventArgs e)
        {
            lboxLista.Items.Clear();
        }

    }
    
    
}
