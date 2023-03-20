using CAN.Task._2.Core;
using System;
using System.Windows;
using System.Windows.Controls;

namespace CAN.Task._2.View.Pages.TaskPages
{

    public partial class Task10Page : Page
    {
        public Task10Page()
        {
            InitializeComponent();
        }

        private void BtnMainPage_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new MainPage());
        }

        private void BtnTask10_1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int A = 1, B = 0, C = 1;
                MessageBox.Show($"rA ={A | ~(A & B) | C}", "Системное сообщение",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnTask10_2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int A = 1, B = 0, C = 1;
                MessageBox.Show($"rB ={~A | C & ~(B | C)}", "Системное сообщение",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnTask10_3_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int A = 1, B = 0, C = 1;
                MessageBox.Show($"rC ={(A | B & ~C) | A}", "Системное сообщение",
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
