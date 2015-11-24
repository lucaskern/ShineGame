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
using System.Windows.Threading;

namespace Shine2.Pages.Levels
{
    /// <summary>
    /// Interaction logic for Safe.xaml
    /// </summary>
    public partial class Safe : UserControl
    {
        DispatcherTimer t1 = new DispatcherTimer();

        int[] combo = new int[3];
        int leftNum = 0;
        int centerNum = 0;
        int rightNum = 0;

        string leftNumString = "0";
        string rightNumString = "0";
        string centerNumString = "0";

        public Safe()
        {
            t1.Interval = TimeSpan.FromSeconds(1.5);

            InitializeComponent();
            combo[0] = 3;
            combo[1] = 0;
            combo[2] = 9;

            left.Text = leftNumString;
            center.Text = centerNumString;
            right.Text = rightNumString;
        }

        //left Up
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (leftNum < 9)
            {
                leftNum++;
                leftNumString = leftNum.ToString();

                left.Text = leftNumString;
            }
            else
            {

            }

        }

        //left Down
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (leftNum > 0)
            {
                leftNum--;
                leftNumString = leftNum.ToString();

                left.Text = leftNumString;
            }
            else
            {

            }
        }

        //center Up
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (centerNum < 9)
            {
                centerNum++;
                centerNumString = centerNum.ToString();

                center.Text = centerNumString;
            }
            else
            {

            }
        }

        //center Down
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (centerNum > 0)
            {
                centerNum--;
                centerNumString = centerNum.ToString();

                center.Text = centerNumString;
            }
            else
            {

            }
        }

        //right Up
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (rightNum < 9)
            {
                rightNum++;
                rightNumString = rightNum.ToString();

                right.Text = rightNumString;
            }
            else
            {

            }
        }

        //right Down
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (rightNum > 0)
            {
                rightNum--;
                rightNumString = rightNum.ToString();

                right.Text = rightNumString;
            }
            else
            {

            }
        }

        //check combo
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if(Check() == "correct")
            {
                t1.Start();
                t1.Tick += Timer_Tick;

               
            } else if (Check() == "incorrect")
            {
                //nothing
            }
        }

        private string Check()
        {
            int[] potential = new int[3];
            potential[0] = leftNum;
            potential[1] = centerNum;
            potential[2] = rightNum;

            if(combo[0] == potential[0] && combo[1] == potential[1] && combo[2] == potential[2])
            {
                isSolved.Foreground = new SolidColorBrush(Colors.Green);
                isSolved.Text = "Correct";
                return "correct";
            }
            else
            {
                isSolved.Foreground = new SolidColorBrush(Colors.Red);
                isSolved.Text = "Incorrect";
                return "incorrect";
            }
        }

        public void Timer_Tick(object sender, EventArgs e)
        {
            t1.Stop();
            Switcher.Switch(new Level5());
        }
    }
}
