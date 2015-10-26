using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFPageSwitch.Menu
{
    /// <summary>
    /// Interaction logic for Level1.xaml
    /// </summary>
    public partial class Level1 : UserControl
    {
        int depthNum = 2;

        public Level1()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            if (depthNum == 2)
            {
                front.Visibility = System.Windows.Visibility.Hidden;
                depthNum -= 1;
            }
            else if (depthNum == 1)
            {
                mid.Visibility = System.Windows.Visibility.Hidden;
                depthNum -= 1;
            }
            else if (depthNum == 0)
            {
                //nothing happens, background is now in front.
            }
            Console.WriteLine(depthNum);
        }

        private void Forward_Click(object sender, RoutedEventArgs e)
        {
            if (depthNum == 2)
            {
                //nothing happens, background is now in front.
            }
            else if (depthNum == 1)
            {
                front.Visibility = System.Windows.Visibility.Visible;
                depthNum += 1;
            }
            else if (depthNum == 0)
            {
                mid.Visibility = System.Windows.Visibility.Visible;
                depthNum += 1;
            }
            Console.WriteLine(depthNum);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You Beat Level 1!");
            Switcher.Switch(new Menu());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new L1Riddle());
        }

    }
}
