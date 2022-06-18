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
using Microsoft.Win32;

namespace Gaz.Lab3._1
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

        private string GetFileName()
        {
            string fname = string.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @"C:\Users\kiril\source\repos\Gaz.Lab3.1";
            openFileDialog.DefaultExt = ".txt";
            openFileDialog.Filter = "Text Documents (.txt)|*.txt";
            bool? open = openFileDialog.ShowDialog();
            if (open == true)
            {
                fname = openFileDialog.FileName;
            }
            else
            {
                MessageBox.Show("Невозможно открыть файл", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            return fname; 
        }

        private void openButton_Click(object sender, RoutedEventArgs e)
        {
            string filename = GetFileName();
            TextFileOperations textFileOperations = new TextFileOperations();
            if (filename != null)
            {
                textBox.Text = textFileOperations.ReadTextFileContents(filename);
            }
            else
            {
                MessageBox.Show("Невозможно открыть файл", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            string filename = GetFileName();
            TextFileOperations textFileOperations = new TextFileOperations();
            if (filename != null)
            {
                textFileOperations.WriteTextFileContents(filename, textBox.Text);
            }
            else
            {
                MessageBox.Show("Невозможно открыть файл", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
