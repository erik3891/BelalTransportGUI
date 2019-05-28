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
    /// Interaction logic for Lønseddel.xaml
    /// </summary>
    public partial class Paycheck : Window
    {
        public Paycheck(string employee)
        {
            InitializeComponent();
            employeebox.Text = employee;
            if (employeebox.Text == "Belal Aldib")
            {
                deductionlabel.Content = "40000";
            }
            else if (employeebox.Text == "Charlotte Hansen")
            {
                deductionlabel.Content = "40000";
            }
            else
            {
                deductionlabel.Content = "401337";
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        
    }
}
