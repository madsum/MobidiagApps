using Multiples.ViewModel;
using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;

namespace Multiples
{
    public partial class MainWindow : Window
    {
        private readonly MultiplesViewModel multiplesViewModel;
        public MainWindow()
        {
            InitializeComponent();
            multiplesViewModel = new MultiplesViewModel();
        }

        private void BtnSum_Click(object sender, RoutedEventArgs e)
        {
            if (!long.TryParse(TbInput.Text, out long input))
            {
                if (input == 0)
                {
                    input = 1000;
                }
            }
            TbResult.Text = String.Format("{0}'s sum of multiples of all 3 or 5 is: {1}",
                input, multiplesViewModel.GetMultiples(input));
            TbInput.Text = "";
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
