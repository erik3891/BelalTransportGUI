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
    public partial class Resultat : Window
    {
        public Resultat()
        {
            InitializeComponent();
        }
        public int Lommeregner(List<int> indtægtList, List<int> udgiftsListe)
        {
            int indtægtSum = indtægtList.Sum();
            int udgiftSum = udgiftsListe.Sum();
            return indtægtSum - udgiftSum;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Udgiftdata = new Udgifter();
          //  var data = Udgiftdata.UdgiftSum; // Ska ind og have fat i udgift summen


        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            var indtægtdata = new Indtægter();
            //var data = indtægtdata.indtægtSum;
        }
    }
}
