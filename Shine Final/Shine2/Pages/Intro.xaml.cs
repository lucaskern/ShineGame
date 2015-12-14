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


namespace Shine2.Pages
{
    /// <summary>
    /// Interaction logic for Intro.xaml
    /// </summary>
    public partial class Intro : UserControl
    {
        //New timer and media player
        DispatcherTimer t1 = new DispatcherTimer();
        DispatcherTimer t2 = new DispatcherTimer();
        private MediaPlayer m1 = new MediaPlayer();

        //int used to count timer ticks
        int num = 0;
        int numSec = 1;

        public Intro()
        {
            //play music
            m1.Open(new Uri(@"../../Assets/Sound/intro.m4a", UriKind.Relative));
            m1.Play();

            //set timer interval to 1/10 of a second, call method on tick, start timer
            t1.Interval = TimeSpan.FromSeconds(.1);
            t1.Tick += Timer_Tick;
            t1.Start();

            //set timer interval to 1 second, call method on tick, start timer
            t2.Interval = TimeSpan.FromSeconds(1);
            t2.Tick += Timer2_Tick;
            t2.Start();


            InitializeComponent();
        }

        //time the page switch so that 
        public void Timer_Tick(object sender, EventArgs e)
        {
            if (num == 460)
            {
                Switcher.Switch(new Menu());
                t1.Stop();
                m1.Stop();
            }
           
            //increase tick #
            num++;
        }


        //every second either make text invisible or visible, a flashing effect
        public void Timer2_Tick(object sender, EventArgs e)
        {
            if (numSec % 2 == 0)
            {
                bottom.Opacity = 100;
                numSec++;
            }
            else
            {
                bottom.Opacity = 0;
                numSec++;
            }
        }

        //end all timers and media, change page
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Menu());
            t1.Stop();
            t2.Stop();
            m1.Stop();
        }
    }
}
