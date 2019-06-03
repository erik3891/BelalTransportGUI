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
                IncomeTaxlabel.Content = 0.38;
                //int CPR = 241285-8585;
            }
            else if (employeebox.Text == "Charlotte Hansen")
            {
                deductionlabel.Content = "40000";
                IncomeTaxlabel.Content = 0.38;
                //int CPR =  1;
            }
            else
            {
                deductionlabel.Content = "401337";
                IncomeTaxlabel.Content = 0.137;
                //int CPR = 1337;
            }
        }

        private void Paycalc_Click(object sender, RoutedEventArgs e)
        {
            double number1 = Int32.Parse(Norpaytime.Text);
            double number2 = Int32.Parse(Norpay.Text);
            double number3 = Int32.Parse(Overpaytime.Text);
            double number4 = Int32.Parse(Overpay.Text);
            double.TryParse(deductionlabel.Content.ToString(),out double Deduction);
            double.TryParse(IncomeTaxlabel.Content.ToString(), out double IncomeTax);
            if (number1 + number3 >= 117)
            {
                ATPlabel.Content = 94.65;
            }
            else if (number1 + number3 >= 78)
            {
                ATPlabel.Content = 63.10;
            }
            else if (number1 + number3 >= 39)
            {
                ATPlabel.Content = 31.55;
            }
            else
            {
                ATPlabel.Content = 0;
            }
            double Pay = (number1 * number2) + (number3 * number4);
            Paylabel.Content = Pay;

            double ATP;
            double.TryParse(ATPlabel.Content.ToString(), out ATP);
            double AM = ((Pay - ATP)* 0.08);
            AMlabal.Content = AM.ToString("#.##");
            double NetPay = (((Pay - Deduction/12) - (ATP + AM)) * (1 - IncomeTax))+Deduction/12;
            NetPaylabel.Content = NetPay.ToString("#.##");
        }

        private void BacktoEmployeeWindow_Click(object sender, RoutedEventArgs e)
        {
            EmployeeWindow employeeWindow = new EmployeeWindow();
            employeeWindow.Show();
            this.Close();
        }
    }
}
