using CAN.Task._2.Core;
using System;
using System.Windows;
using System.Windows.Controls;

namespace CAN.Task._2.View.Pages.TaskPages
{
    public partial class Task5Page : Page
    {
        public Task5Page()
        {
            InitializeComponent();
        }

        private void BtnMainPage_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new MainPage());
        }

        private void BtnTask5_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(TbA.Text);
                double b = Convert.ToDouble(TbB.Text);

                MessageBox.Show($"G = {(a % 2 == 1) && (b % 2 == 1)}", "Системное сообщение",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);

                TbA.Text = string.Empty;
                TbB.Text = string.Empty;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
