using Multiples.ViewModel;
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

namespace Multiples
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
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
