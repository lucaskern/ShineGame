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
        private MediaPlayer media = new MediaPlayer();

       //int used to count timer ticks
        int num = 0;
        
        public Intro()
        {
            //play music
            media.Open(new Uri(@"../../Assets/Sound/intro.m4a", UriKind.Relative));
            media.Play();

            //set timer interval to 1/10 of a second, call method on tick, start timer
            t1.Interval = TimeSpan.FromSeconds(.1);
            t1.Tick += Timer_Tick;
            t1.Start();
           
            InitializeComponent();
        }

        public void Timer_Tick(object sender, EventArgs e)
        {
            //Statement to increase font size at specific times
            //if ( )
            //{
            //    bottom.Opacity = bottom.Opacity + 5;
                
            //    //change page at 5 seconds, stop music
            //}
            //else if (num == 480)
            //{
            //    Switcher.Switch(new Menu());
            //    t1.Stop();
            //}
            //increase tick #
            num++;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Menu());
            t1.Stop();
            media.Stop();
        }
    }
}
