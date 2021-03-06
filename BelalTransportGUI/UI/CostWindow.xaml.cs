﻿using System;
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
    /// Interaction logic for Udgifter.xaml
    /// </summary>
    public partial class CostWindow : Window
    {
        public CostWindow()
        {
            InitializeComponent();
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (nummer1.Text == "" || nummer2.Text == "")
            {
                MessageBox.Show("Indtask indtægt");
            }
            else
            {
                int summen = 0;// opretter vores udregning hvor den ska gemmes
                summen = int.Parse(nummer1.Text) + int.Parse(nummer2.Text); // starter udregning med at pluse tekstbox med hinanden 

                UdgiftsSum.Text = summen.ToString();// henter "den" tekstbox og putter summen ind i det

            }

        }
           private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            BalanceWindow resultat = new BalanceWindow();
            resultat.Show(); this.Close();
     
           resultat.udgifterSum.Text =UdgiftsSum.Text.ToString();
        
        }

        
                      


        private void Nummer1_KeyDown(object sender, KeyEventArgs e)
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
            }

        }

        private void Nummer2_KeyDown(object sender, KeyEventArgs e)
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
            }
        }

        private void Tilbage_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }

      
      
    }
}





