using MobidiagApp2.ViewModel;
using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;

namespace MobidiagApp2
{
    public partial class MainWindow : Window
    {
        private MobidiagAppViewModel mobidiagAppViewModel;
        public MainWindow()
        {
            InitializeComponent();
            mobidiagAppViewModel = new MobidiagAppViewModel();
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            string name = (sender as Button).Name.ToString();

            if (string.Equals(name, "BtnTotalMutiple"))
            {
                TbResult.Text = string.Format("{0}'s sum of multiples of all 3 or 5 is: {1}",
                    mobidiagAppViewModel.GetTotalMutipleInput(TbInput.Text),
                    mobidiagAppViewModel.GetTotalMutiple(TbInput.Text));
            }
            else if (string.Equals(name, "BtnFibSum"))
            {
                TbResult.Text = string.Format("{0} Fibonacci sequence even number summation is: {1}",
                    mobidiagAppViewModel.GetFibSumIput(TbInput.Text),
                    mobidiagAppViewModel.GetSumOfFibEvenNumber(TbInput.Text));
            }
            else if (string.Equals(name, "BtnPrimeNumber"))
            {
                TbResult.Text = string.Format("{0}'s largest prime factor number is: {1}",
                    mobidiagAppViewModel.GetPrimeInput(TbInput.Text),
                    mobidiagAppViewModel.GetLargestPrime(TbInput.Text));
            }
            TbInput.Text = "";
        }

        private void TbInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            Regex _regex = new Regex("[^0-9.-]+");
            if (_regex.IsMatch(TbInput.Text))
            {
                AlertPopup.IsOpen = true;
                Console.Beep();
                BtnTotalMutiple.IsEnabled = false;
            }
            else
            {
                AlertPopup.IsOpen = false;
                BtnTotalMutiple.IsEnabled = true;
            }
        }

    }
}
