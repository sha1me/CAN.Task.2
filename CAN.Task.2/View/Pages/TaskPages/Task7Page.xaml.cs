using CAN.Task._2.Core;
using System.Windows;
using System.Windows.Controls;

namespace CAN.Task._2.View.Pages.TaskPages
{
    public partial class Task7Page : Page
    {
        public Task7Page()
        {
            InitializeComponent();
        }

        private void BtnMainPage_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new MainPage());
        }

        private void BtnTask7_1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnTask7_2_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
