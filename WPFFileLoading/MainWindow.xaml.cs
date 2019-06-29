using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

namespace WPFFileLoading
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DownloadFile(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(urlTextBox.Text))
            {
                MessageBox.Show("Введите URL");
                return;
            }
            if (string.IsNullOrWhiteSpace(fileTextBox.Text))
            {
                MessageBox.Show("Введите название файла");
                return;
            }
            using (WebClient client = new WebClient())
            {
                try
                {
                    client.DownloadFileAsync(new Uri(urlTextBox.Text), fileTextBox.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка");
                }
            }
        }
    }
}
