using LargestPrime.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace LargestPrime
{
    public partial class MainWindow : Window
    {
        private LargestPrimeViewModel largestPrimeViewModel;
        public MainWindow()
        {
            InitializeComponent();
            largestPrimeViewModel = new LargestPrimeViewModel();
        }

        private void BtnSum_Click(object sender, RoutedEventArgs e)
        {
            if (!ulong.TryParse(TbInput.Text, out ulong input))
            {
                if (input == 0)
                {
                    input = 6_008_514_751_43;
                }
            }
            TbBesult.Text = String.Format("{0}'s largest prime factor number is: {1}",
                            input, largestPrimeViewModel.GetLargestPrime(input));
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