using EvenFibonacci.ViewModel;
using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;

namespace EvenFibonacci
{
    public partial class MainWindow : Window
    {
        private EvenFibonacciViewModel evenFibonacciViewModel;
        public MainWindow()
        {
            InitializeComponent();
            evenFibonacciViewModel = new EvenFibonacciViewModel();
        }

        private void BtnSum_Click(object sender, RoutedEventArgs e)
        {
            if (!ulong.TryParse(TbInput.Text, out ulong input))
            {
                if (input == 0)
                {
                    input = 4_000_000;
                }
            }
            TbBesult.Text = String.Format("{0} Fibonacci sequence even number summation is: {1}",
                input, evenFibonacciViewModel.SumOfFibEvenNumber(input));
            TbInput.Text = "";
        }

        public ulong SumOfFibEvenNumber(ulong range)
        {
            ulong fib2 = 0, fib3 = 1;
            ulong sum = 0;
            for (ulong i = 1; i <= range; i++)
            {
                ulong finb1 = fib2;
                fib2 = fib3;
                fib3 = finb1 + fib2;
                if (fib3 % 2 == 0)
                {
                    sum += fib3;
                }
            }
            return sum;
        }

        private void TbInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            Regex _regex = new Regex("[^0-9.-]+");
            if (_regex.IsMatch(TbInput.Text))
            {
                AlertPopup.IsOpen = true;
                Console.Beep();
                BtnSum.IsEnabled = false;
            }
            else
            {
                AlertPopup.IsOpen = false;
                BtnSum.IsEnabled = true;
            }

        }
    }
}
