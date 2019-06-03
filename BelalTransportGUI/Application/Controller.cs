using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelalTransportGUI
{
    class Controller
    {
        public void GetUdgifter()
        {
            Udgifter udgifter = new Udgifter();
            Resultat resultat = new Resultat();
            
            resultat.udgifterSum.Text = udgifter.den.Text.ToString();
            
            resultat.Show();
            udgifter.Close();

            
        }
    }
}
