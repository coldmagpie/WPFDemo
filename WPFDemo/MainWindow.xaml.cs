using System;
using System.Net.Mime;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Input;

namespace WPFDemo
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
            if (e.Source is Button button)
            {
                if (MinText.Text == "0" && button.Content+"" != ",")
                {
                    MinText.Text = String.Empty;

                }
                MinText.Text += button.Content;
            }
        }

        private void ClearButtonClick(object sender, RoutedEventArgs e)
        {
            MinText.Text = string.Empty;
        }

        private void EqualsButtonClick(object sender, RoutedEventArgs e)
        {
            //var expression = MinText.Text;
            //var numbers = expression.Split('+','-','x','/');
            //var num1 = float.Parse(numbers[0]);
            //var num2 = float.Parse(numbers[1]);

            //var sum = num1 + num2;

            //MinText.Text = sum+"";



            string input;
            string operators = "+-/x";
            char op = ' ';
            int opIndex = 0;
            string siffra1 = String.Empty;
            string siffra2 = String.Empty;
            double result = 0;

            input = MinText.Text;

            for (int i = 0; i < input.Length; i++)
            {
                if (operators.Contains(input[i]))
                {
                    op = input[i];
                    opIndex = i;
                }
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (opIndex > i)
                {
                    siffra1 += input[i];
                }
                else if (opIndex < i)
                {
                    siffra2 += input[i];
                }
            }

            switch (op)
            {
                case '+':
                    result = double.Parse(siffra1) + double.Parse(siffra2);
                    break;

                case '-':
                    result = double.Parse(siffra1) - double.Parse(siffra2);
                    break;

                case 'x':
                    result = double.Parse(siffra1) * double.Parse(siffra2);
                    break;

                case '/':
                    result = double.Parse(siffra1) / double.Parse(siffra2);
                    break;

                default:
                    MinText.Text = "Ogiltligt";
                    break;
            }
            MinText.Text = result + "";
        }

        private void ButtonClickDel(object sender, RoutedEventArgs e)
        {
            MinText.Text = MinText.Text.Substring(0, MinText.Text.Length - 1);
        }
    }
}


//if (e.Key == Key.Enter)