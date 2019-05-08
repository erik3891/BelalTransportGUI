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
        public int Lommeregner(List<int> indtægtList, List<int> udgiftsListe)
        {
            int indtægtSum = indtægtList.Sum();
            int udgiftSum = udgiftsListe.Sum();
            return indtægtSum - udgiftSum;
            public Resultat()
        {
            InitializeComponent();
        }
    }
}
