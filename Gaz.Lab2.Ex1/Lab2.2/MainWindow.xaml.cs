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

namespace Lab2._2
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

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            double number = 0;
            if (!Double.TryParse(inputTextBox.Text, out number) || (number < 0))
            {
                MessageBox.Show("Введите неотрицательное число", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                double sqrt = Math.Sqrt(number);
                frameworkLabel.Content = sqrt + " (Using the .NET Framework)";
            }




            decimal dec, delt, guess, res;

            if (!decimal.TryParse(inputTextBox.Text, out dec))
            {
                MessageBox.Show("Введено не десятичное число", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                delt = Convert.ToDecimal(Math.Pow(10, -28));
                guess = dec / 2;
                res = ((dec / guess) + guess) / 2;
                if (dec < 0)
                {
                    MessageBox.Show("Введено отрицательное число", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                while (Math.Abs(res - guess) > delt)
                {
                    guess = res;
                    res = ((dec / guess) + guess) / 2;
                }
                newtonLabel.Content = res + "(Using Newton)";
            }
        }
    }
}
