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

namespace WpfApp2
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

            bool ugyanolyan = false;

            foreach (var item in lboxLista.Items)
            {
                if (item.Equals(szinadatok))
                {
                    MessageBox.Show("ilyen színadat már létezik");
                    ugyanolyan = true;
                    break;
                }
            }
            if (!ugyanolyan)
                lboxLista.Items.Add(szinadatok);


        }

        private void btnTorol_Click(object sender, RoutedEventArgs e)
        {
            if (lboxLista.SelectedIndex >= 0)
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
            sliPiros.Value = 0;
            sliZold.Value = 0;
            sliKek.Value = 0;
        }

        private void lboxLista_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lboxLista.SelectedIndex >= 0)
            {
                string[] tagok = lboxLista.SelectedItem.ToString().Split(';');
                sliPiros.Value = Convert.ToDouble(tagok[0]);
                sliZold.Value = Convert.ToDouble(tagok[1]);
                sliKek.Value = Convert.ToDouble(tagok[2]);
            }
            
            

        }
    }
}
    
