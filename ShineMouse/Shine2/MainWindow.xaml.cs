using System;
using System.Windows;
using System.Windows.Controls;
using Shine2.Pages;
using System.Windows.Threading;

namespace Shine2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();
            Switcher.pageSwitcher = this;
            Switcher.Switch(new Shine2.Pages.Intro());      
        }

        public void Navigate(UserControl nextPage)
        {
            this.Content = nextPage;
        }
    }
}
