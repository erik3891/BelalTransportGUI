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
            ConnectionDB connectiondb = new ConnectionDB();
            //foreach (string item in connectiondb.GetEmployees())
            //{
            //    ListBoxItem itm = new ListBoxItem();
            //    itm.Content = item;

            //    employeelist.Items.Add(itm);
            //}
            //employeelist.Items.Add(new ListBoxItem { Content = connectiondb.GetEmployees()});
        }
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
