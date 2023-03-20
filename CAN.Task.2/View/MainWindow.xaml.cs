using CAN.Task._2.Core;
using CAN.Task._2.View.Pages;
using System.Windows;

namespace CAN.Task._2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CoreNavigate.MyConnection = MainFrame;
            MainFrame.Navigate(new MainPage());
        }
    }
}
