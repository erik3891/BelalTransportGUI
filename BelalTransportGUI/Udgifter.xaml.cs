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
    /// Interaction logic for Udgifter.xaml
    /// </summary>
    public partial class Udgifter : Window
    {
        public Udgifter()
        {
            InitializeComponent();
        }

        protected void Button_Click(object sender, RoutedEventArgs e)
        {
            int summen = 0;// opretter vores udregning hvor den ska gemmes
            summen = int.Parse(nummer1.Text) + int.Parse(nummer2.Text); // starter udregning med at pluse tekstbox med hinanden 

            den.Text = summen.ToString();// henter "den" tekstbox og putter summen ind i det

            List<TextBox> udgiftsliste = new List<TextBox>();

            udgiftsliste.Add(nummer1);
            udgiftsliste.Add(nummer2);
            
           
                
  
            
            


            /* Udgifter udgift = new Udgifter(nummer1.Text + nummer2.Text);
             udgift.Show();*/
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

        //private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        //{

        //}
    }
}


/* public List<double> liste = new List<double>();
 //liste.Add();
 public List<string> UdgiftFelt = new List<string>();
 public List<double> udgiftsliste = new List<double>();
 int row = 0;
 int Udgiftsnummer = 0;
 int column = 0;

 public void AddExpense()
 {
     bool exit = true;
     bool looping = true;
     row = 0;
     Console.SetCursorPosition(row, column);

     while (exit)
     {
         looping = true;
         row = 0;
         Console.SetCursorPosition(row, column);
         Console.SetCursorPosition(row + 5, column);
         string input = Console.ReadLine();

         if (input.Equals(string.Empty))
         {
             exit = false;
         }

         else if (input is string)
         {
             UdgiftFelt.Add(input);
             row = 30;

             while (looping)
             {
                 Console.SetCursorPosition(row, column);
                 input = Console.ReadLine();

                 if (int.TryParse(input, out Udgiftsnummer))
                 {
                     udgiftsliste.Add(Udgiftsnummer);
                     column += 1;
                     looping = false;
                 }

                 else
                 {
                     Console.WriteLine("Virker ikke");
                 }




             }
         }

     }
 }*/

/* private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
 {

 }

 private void TextBox_TextChanged(object sender, TextChangedEventArgs e, Int32)
 {
     int Udgift = 0;
     sender = Udgift;
     if (sender == e)
     {

     }


 }*/

/*private void TextBox_KeyDown(object sender, KeyEventArgs e)
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


}*/


