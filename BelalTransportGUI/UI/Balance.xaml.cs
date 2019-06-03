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
using System.Windows.Shapes;

namespace BelalTransportGUI
{
    /// <summary>
    /// Interaction logic for Resultat.xaml
    /// </summary>
    public partial class Balance : Window
    {
        public Balance()
        {
            InitializeComponent();
        }
        
       

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var CostData = new Cost();
          //  var data = Udgiftdata.UdgiftSum; // Ska ind og have fat i udgift summen


        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            var indtægtdata = new Income();
            //var data = indtægtdata.indtægtSum;
        }

        private void Tilbage_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }

        private void IndtægtSum_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.NumPad0:
                case Key.NumPad1:
                case Key.NumPad2:
                case Key.NumPad3:
                case Key.NumPad4:
                case Key.NumPad5:
                case Key.NumPad6:
                case Key.NumPad7:
                case Key.NumPad8:
                case Key.NumPad9:
                case Key.D0:
                case Key.D1:
                case Key.D2:
                case Key.D3:
                case Key.D4:
                case Key.D5:
                case Key.D6:
                case Key.D7:
                case Key.D8:
                case Key.D9:
                    break;
                default:
                    e.Handled = true;
                    break;

                    ;
            }
        }

        private void UdgifterSum_KeyDown(object sender, KeyEventArgs e)
        {
           
            switch (e.Key)
            {
                case Key.NumPad0:
                case Key.NumPad1:
                case Key.NumPad2:
                case Key.NumPad3:
                case Key.NumPad4:
                case Key.NumPad5:
                case Key.NumPad6:
                case Key.NumPad7:
                case Key.NumPad8:
                case Key.NumPad9:
                case Key.D0:
                case Key.D1:
                case Key.D2:
                case Key.D3:
                case Key.D4:
                case Key.D5:
                case Key.D6:
                case Key.D7: 
                case Key.D8:
                case Key.D9:
                    break;
                default:
                    e.Handled = true;
                    break;

                    ;
            }

        }

      
    }
}
