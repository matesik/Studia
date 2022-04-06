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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string coma = System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator;

        private string operation = "";
        private string previousNumber = "";
        public MainWindow()
        {
            InitializeComponent();
            number_input.TextAlignment = TextAlignment.Right;

        }

        private void button_clicked(object sender, RoutedEventArgs e)
        {

            Button button = sender as Button;
            bool isInvalid = string.IsNullOrWhiteSpace(number_input.Text);
            bool isZero = ((string)button?.Content == "0");

            _ = isInvalid && isZero ? (number_input.Text += $"0{coma}") : (number_input.Text += button?.Content);
        }

        private void button_coma_Click(object sender, RoutedEventArgs e)
        {
            bool isInvalid = string.IsNullOrWhiteSpace(number_input.Text);
            bool hasComa = number_input.Text.Contains(coma);

            if (!hasComa)
            {
                _ = isInvalid ? (number_input.Text = $"0{coma}") : (number_input.Text += coma);
            }
        }

        private void button_add_Click(object sender, RoutedEventArgs e)
        {
            prepareForCalculation("+");
        }

        private void button_subtract_Click(object sender, RoutedEventArgs e)
        {
            prepareForCalculation("-");
        }
        private void button_multiply_Click(object sender, RoutedEventArgs e)
        {
            prepareForCalculation("*");
        }
        private void button_divide_Click(object sender, RoutedEventArgs e)
        {
            prepareForCalculation("/");
        }

        private void prepareForCalculation(string operation)
        {
            button_deleteLast.IsEnabled = true;
            this.operation = operation;
            if (!string.IsNullOrWhiteSpace(number_input.Text))
            {
                previousNumber = number_input.Text;
                number_input.Text = null;
            }
        }

        private void button_delete_Click(object sender, RoutedEventArgs e)
        {
            number_input.Text = null;
            button_deleteLast.IsEnabled = true;
        }
        private void button_deleteLast_Click(object sender, RoutedEventArgs e)
        {
            bool isInvalid = string.IsNullOrWhiteSpace(number_input.Text);

            if (!isInvalid)
            {
                number_input.Text = number_input.Text.Remove(number_input.Text.Length - 1);
            }
        }

        private void button_solve_Click(object sender, RoutedEventArgs e)
        {
            bool isInvalid = string.IsNullOrWhiteSpace(number_input.Text);
            string result = "";
            double.TryParse(previousNumber, out double previousNumberAsDouble);
            double.TryParse(number_input.Text, out double currentNumberAsDouble);

            if (!isInvalid)
            {
                if (operation == "+")
                {
                    result = (previousNumberAsDouble + currentNumberAsDouble).ToString();
                }

                if (operation == "-")
                {
                    result = (previousNumberAsDouble - currentNumberAsDouble).ToString();
                }

                if (operation == "*")
                {
                    result = (previousNumberAsDouble * currentNumberAsDouble).ToString();
                }

                if (operation == "/")
                {
                    if (currentNumberAsDouble == 0)
                    {
                        result = "Nie wolno dzielic przez 0";
                    }
                    else
                    {
                        result = (previousNumberAsDouble / currentNumberAsDouble).ToString();
                    }
                }

                if (operation == "")
                {
                    result = currentNumberAsDouble.ToString();
                }
            }
            if(result.Contains("E"))
            {
                button_deleteLast.IsEnabled = false;
            }
            number_input.Text = result;
            previousNumber = result;
            currentNumberAsDouble = 0;
            operation = "";
        }

    }

}
