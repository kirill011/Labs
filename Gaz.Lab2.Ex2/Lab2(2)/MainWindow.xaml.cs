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

namespace Lab2_2_
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
            int i;
            if (!int.TryParse(inputTextBox.Text, out i) || i < 0)
            {
                MessageBox.Show("Введите целое неотрицательное число","Ошибка",MessageBoxButton.OK,MessageBoxImage.Error);
            }
            else
            {
                int res = 0;
                StringBuilder binary = new StringBuilder();
                do
                {
                    res = i % 2;
                    i /= 2;
                    binary.Insert(0, res);
                } while (i > 0);
                Label1.Content = binary.ToString();
            }
        }
    }
}
