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
        //timer to make space for safe unlock sound
        DispatcherTimer t1 = new DispatcherTimer();

        MediaPlayer media = new MediaPlayer();

        //combo is three numbers
        int[] combo = new int[3];
        //sets start values of numbers
        int leftNum = 0;
        int centerNum = 0;
        int rightNum = 0;

        //display values are 0 to start
        string leftNumString = "0";
        string rightNumString = "0";
        string centerNumString = "0";

        
        public Safe()
        {
            t1.Interval = TimeSpan.FromSeconds(2);

            InitializeComponent();
            //set the correct combo
            combo[0] = 3;
            combo[1] = 0;
            combo[2] = 9;

            //set textbox values
            left.Text = leftNumString;
            center.Text = centerNumString;
            right.Text = rightNumString;
        }

        //loops audio
        private void media_Ended(object sender, EventArgs e)
        {
            media.Close();
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
            else if (leftNum == 9)
            {
                leftNum = 0;
                leftNumString = leftNum.ToString();

                left.Text = leftNumString;
            } else
            {

            }

            //play click
            media.Open(new Uri(@"../../Assets/Sound/safeClick.m4a", UriKind.Relative));
            media.Play();
            media.MediaEnded += new EventHandler(media_Ended);
            
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
            else if (leftNum == 0)
            {
                leftNum = 9;
                leftNumString = leftNum.ToString();

                left.Text = leftNumString;
            } else
            {

            }

            //play click
            media.Open(new Uri(@"../../Assets/Sound/safeClick.m4a", UriKind.Relative));
            media.Play();
            media.MediaEnded += new EventHandler(media_Ended);
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
            else if (centerNum == 9)
            {
                centerNum = 0;
                centerNumString = centerNum.ToString();

                center.Text = centerNumString;
            }
            else { }

            //play click
            media.Open(new Uri(@"../../Assets/Sound/safeClick.m4a", UriKind.Relative));
            media.Play();
            media.MediaEnded += new EventHandler(media_Ended);
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
            else if (centerNum == 0)
            {
                centerNum = 9;
                centerNumString = centerNum.ToString();

                center.Text = centerNumString;
            }
            else { }

            //play click
            media.Open(new Uri(@"../../Assets/Sound/safeClick.m4a", UriKind.Relative));
            media.Play();
            media.MediaEnded += new EventHandler(media_Ended);
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
            else if (rightNum == 9)
            {
                rightNum = 0;
                rightNumString = rightNum.ToString();

                right.Text = rightNumString;
            }
            else { }

            //play click
            media.Open(new Uri(@"../../Assets/Sound/safeClick.m4a", UriKind.Relative));
            media.Play();
            media.MediaEnded += new EventHandler(media_Ended);
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
            else if (rightNum == 0)
            {
                rightNum = 9;
                rightNumString = rightNum.ToString();

                right.Text = rightNumString;
            }
            else { }

            //play click
            media.Open(new Uri(@"../../Assets/Sound/safeClick.m4a", UriKind.Relative));
            media.Play();
            media.MediaEnded += new EventHandler(media_Ended);
        }

        //check combo
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if(Check() == "correct")
            {
                t1.Start();
                t1.Tick += Timer_Tick;

                //play click
                media.Open(new Uri(@"../../Assets/Sound/unlock.m4a", UriKind.Relative));
                media.Play();

               
            } else if (Check() == "incorrect")
            {
                //nothing
            }
        }

        
        private string Check()
        {
            //potential is a "middleman" used to check combo against user entered code
            int[] potential = new int[3];
            potential[0] = leftNum;
            potential[1] = centerNum;
            potential[2] = rightNum;

            //if the user enters correct combo do this, else return incorrect
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

        //go to L5
        public void Timer_Tick(object sender, EventArgs e)
        {
            t1.Stop();
            Switcher.Switch(new Level5());
        }

        //Leave safe and go back to L1
        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Level4());
        }
    }
}
