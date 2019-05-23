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
    /// Interaction logic for Medarbejder.xaml
    /// </summary>
    public partial class EmployeeWindow : Window
    {
        public EmployeeWindow()
        {
            InitializeComponent();

            //ListBoxItem item = new ListBoxItem();
            //string employeedata ="";
            //item.Content = connectiondb.GetAllEmployees();

            //employeelist.Items.Add(item);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (employeelist.SelectedItem != null)
            {
                var employee = (employeelist.SelectedItem as ListBoxItem).Content;
                Paycheck paycheck = new Paycheck(employee.ToString());
                paycheck.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("Vælg medarbejder");
            }
        }
    }
}