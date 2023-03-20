using CAN.Task._2.Core;
using System;
using System.Windows;
using System.Windows.Controls;

namespace CAN.Task._2.View.Pages.TaskPages
{
    public partial class Task9Page : Page
    {
        public Task9Page()
        {
            InitializeComponent();
        }

        private void BtnMainPage_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new MainPage());
        }

        private void BtnTask9_1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int x = 2, y = 1;
                MessageBox.Show($"rX ={((x * y < 0)) || (y > x)}", "Системное сообщение",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnTask9_2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int x = 2, y = 1;
                MessageBox.Show($"rY ={(x * y != 0) && (y < x)}", "Системное сообщение",
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
