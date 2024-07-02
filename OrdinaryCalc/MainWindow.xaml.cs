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

namespace OrdinaryCalc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private decimal Operend = decimal.MinValue;
        private string Operation = string.Empty;    
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
            {

            }

        private void Button_ClickClear(object sender, RoutedEventArgs e)
            {
            CountTextBox.Text = "0";
            Operend = 0;
            Operation = string.Empty;
            }

        private void Button_Click_1(object sender, RoutedEventArgs e)
            {

            CountTextBox.Text = CountTextBox.Text == "0"| Operation != string.Empty? (CountTextBox.Text = "1"):(CountTextBox.Text +=  "1");

            }

        private void Button_Click_2(object sender, RoutedEventArgs e)
            {
            CountTextBox.Text = CountTextBox.Text == "0" | Operation != string.Empty ? (CountTextBox.Text = "2") : (CountTextBox.Text += "2");
            }

        private void Button_Click_3(object sender, RoutedEventArgs e)
            {
            CountTextBox.Text = CountTextBox.Text == "0" | Operation != string.Empty ? (CountTextBox.Text = "3") : (CountTextBox.Text += "3");
            }

        private void Button_Click_4(object sender, RoutedEventArgs e)
            {
            CountTextBox.Text = CountTextBox.Text == "0" | Operation != string.Empty ? (CountTextBox.Text = "4") : (CountTextBox.Text += "4");
            }

        private void Button_Click_5(object sender, RoutedEventArgs e)
            {
            CountTextBox.Text = CountTextBox.Text == "0" | Operation != string.Empty ? (CountTextBox.Text = "5") : (CountTextBox.Text += "5");
            }

        private void Button_Click_6(object sender, RoutedEventArgs e)
            {
            CountTextBox.Text = CountTextBox.Text == "0" | Operation != string.Empty ? (CountTextBox.Text = "6") : (CountTextBox.Text += "6");
            }

        private void Button_Click_7(object sender, RoutedEventArgs e)
            {
            CountTextBox.Text = CountTextBox.Text == "0" | Operation != string.Empty ? (CountTextBox.Text = "7") : (CountTextBox.Text += "7");
            }
      

        private void Button_Click_8(object sender, RoutedEventArgs e)
            {
            CountTextBox.Text = CountTextBox.Text == "0" | Operation != string.Empty ? (CountTextBox.Text = "8") : (CountTextBox.Text += "8");
            }

        private void Button_Click_9(object sender, RoutedEventArgs e)
            {
            CountTextBox.Text = CountTextBox.Text == "0" | Operation != string.Empty ? (CountTextBox.Text = "9") : (CountTextBox.Text += "9");
            }

        private void Button_Click_0(object sender, RoutedEventArgs e)
            {
            CountTextBox.Text = CountTextBox.Text == "0" | Operation != string.Empty ? (CountTextBox.Text = "0") : (CountTextBox.Text += "0");
            }

        private void Close_MouseDown(object sender, MouseButtonEventArgs e)
            {
            this.Close();
            }

        private void Minimaze_MouseDown(object sender, MouseButtonEventArgs e)
            {
            this.WindowState = WindowState.Minimized;   
            }

        private void ToolBar_MouseDown(object sender, MouseButtonEventArgs e)
            {
            if (e.ChangedButton == MouseButton.Left)
                { this.DragMove(); }
            }

      
        private void Button_Click_add(object sender, RoutedEventArgs e)
        {
            Operend = Convert.ToDecimal(CountTextBox.Text);
            Operation = "+";
           
        }

       

        private void Button_Click_subtract(object sender, RoutedEventArgs e)
        {
            Operend = Convert.ToDecimal(CountTextBox.Text);
            Operation = "-";
        }

        private void Button_Click_multiply(object sender, RoutedEventArgs e)
        {
            Operend = Convert.ToDecimal(CountTextBox.Text);
            Operation = "*";
        }

        private void Button_Click_divide(object sender, RoutedEventArgs e)
        {
            Operend = Convert.ToDecimal(CountTextBox.Text);
            Operation = "/";
        }

        private void Button_Click_equal(object sender, RoutedEventArgs e)
        {
            switch (Operation)
            {
                case  "+":
                    {
                        Operend = Operend + Convert.ToDecimal(CountTextBox.Text);
                        CountTextBox.Text = Convert.ToString(Operend);
                    };
                    break;

                case "-":
                    {
                        Operend = Operend - Convert.ToDecimal(CountTextBox.Text);
                        CountTextBox.Text = Convert.ToString(Operend);
                    };
                    break;

                case "*":
                    {
                        Operend = Operend * Convert.ToDecimal(CountTextBox.Text);
                        CountTextBox.Text = Convert.ToString(Operend);
                    }
                    break;

                case "/":
                    {
                        if (CountTextBox.Text == "0")
                        { CountTextBox.Text = "Error"; }
                        else 
                        { 
                        Operend = Operend / Convert.ToDecimal(CountTextBox.Text);
                        CountTextBox.Text = Convert.ToString(Operend);
                        }
                    };  
                    break;  
                
            }
        }

        private void Button_Click_percentage(object sender, RoutedEventArgs e)
        {
            Operend = Convert.ToDecimal(CountTextBox.Text);
            Operation = "%";
        }

        private void Button_Click_change(object sender, RoutedEventArgs e)
        {
            if (CountTextBox.Text.Contains("-"))
            { CountTextBox.Text = CountTextBox.Text.Trim('-'); }
            else { CountTextBox.Text = "-" + CountTextBox.Text; }
        }

        private void Button_Click_comma(object sender, RoutedEventArgs e)
        {
            if (!CountTextBox.Text.Contains(","))
                { CountTextBox.Text += ","; }
        }
    }
}
