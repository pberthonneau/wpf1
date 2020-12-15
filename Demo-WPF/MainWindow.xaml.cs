using System;
using System.Windows;
using System.Windows.Input;

namespace Demo_WPF
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Click");
        }

        private void Label_MouseEnter(object sender, MouseEventArgs e)
        {
            Console.WriteLine("Enter");
        }

        private void Label_MouseLeave(object sender, MouseEventArgs e)
        {
            Console.WriteLine("Leave");
        }
    }
}
