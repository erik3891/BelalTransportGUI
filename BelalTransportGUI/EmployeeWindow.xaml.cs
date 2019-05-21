using System;
using System.Collections;
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
        }

        private void ListBox_SelectionChanged(object sender, RoutedEventArgs e)
        {
            //medarbejderlist.DataSource = MyList;
            //for (int i = 0; i < ConnectionDB.employees.Count; i++)
            //{
            //    medarbejderlist.Items.Add(ConnectionDB.employees.ElementAt(i));
            //}
        }
    }
}
