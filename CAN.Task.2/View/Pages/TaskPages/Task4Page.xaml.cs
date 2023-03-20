using CAN.Task._2.Core;
using System;
using System.Windows;
using System.Windows.Controls;

namespace CAN.Task._2.View.Pages.TaskPages
{
    public partial class Task4Page : Page
    {
        public Task4Page()
        {
            InitializeComponent();
        }

        private void BtnMainPage_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new MainPage());
        }

        private void BtnTask4_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(TbA.Text);

                MessageBox.Show($"A = {(a % 2 == 0) || (a % 3 == 0)}", "Системное сообщение",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);

                TbA.Text = string.Empty;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
