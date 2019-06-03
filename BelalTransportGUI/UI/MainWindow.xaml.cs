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

namespace BelalTransportGUI
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            EmployeeWindow employee = new EmployeeWindow();
            employee.Show();
            this.Close();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            Cost cost = new Cost();
            cost.Show();
            this.Close();
        }

      

        private void Indtægter_Click(object sender, RoutedEventArgs e)
        {
            Income income = new Income();
            income.Show();
            this.Close();
        }

        private void Resultat_Click(object sender, RoutedEventArgs e)
        {
            Balance balance = new Balance();
            balance.Show();
            this.Close();
        }
    }
}
