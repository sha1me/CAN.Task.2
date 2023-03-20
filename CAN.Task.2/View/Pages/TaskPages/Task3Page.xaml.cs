using CAN.Task._2.Core;
using System;
using System.Windows;
using System.Windows.Controls;

namespace CAN.Task._2.View.Pages.TaskPages
{
    public partial class Task3Page : Page
    {
        public Task3Page()
        {
            InitializeComponent();
        }

        private void BtnMainPage_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new MainPage());
        }

        private void BtnTask3_1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int x = 2, y = 1;
                MessageBox.Show($"rX ={((x * y < 0)) & (y > x)}", "Системное сообщение",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnTask3_2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int x = 2, y = 1;
                MessageBox.Show($"rY ={(x >= 2) | (Math.Pow(y, 2) != 5)}", "Системное сообщение",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
