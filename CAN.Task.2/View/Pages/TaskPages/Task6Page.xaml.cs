using CAN.Task._2.Core;
using System;
using System.Windows;
using System.Windows.Controls;

namespace CAN.Task._2.View.Pages.TaskPages
{
    public partial class Task6Page : Page
    {
        public Task6Page()
        {
            InitializeComponent();
        }

        private void BtnMainPage_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new MainPage());
        }

        private void BtnTask6_1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int X = 0, Y = 0, Z = 1;
                MessageBox.Show($"rX ={X | Y & ~Z}", "Системное сообщение",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnTask6_2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int X = 0, Y = 0, Z = 1;
                MessageBox.Show($"rY ={~X & ~Y}", "Системное сообщение",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnTask6_3_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int X = 0, Y = 0, Z = 1;
                MessageBox.Show($"rZ ={~(X & Z) | Y}", "Системное сообщение",
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
