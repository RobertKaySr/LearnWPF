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
        double lastNumber, result;
        public MainWindow()
        {
            InitializeComponent();
            acButton.Click += AcButton_Click;
            twoButton.Click += TwoButton_Click;
            minusButton.Click += MinusButton_Click;
            zeroButton.Click += ZeroButton_Click;
            plusNegativeButton.Click += PlusNegativeButton_Click;
        }

        private void PlusNegativeButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(resultLabel.Content.ToString(), out lastNumber))
            {
                lastNumber = lastNumber * -1;
                resultLabel.Content = lastNumber.ToString();
            }
            else
            {
                resultLabel.Content = 15;
            }
        }

        private void ZeroButton_Click(object sender, RoutedEventArgs e)
        {
            result = result * -2;
        }

        private void MinusButton_Click(object sender, RoutedEventArgs e)
        {


        }

        private void TwoButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AcButton_Click(object sender, RoutedEventArgs e)
        {
            resultLabel.Content = "0";
        }

        private void SevenButton_Click(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = "7";
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}7";

            }
        }
    }
}
