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
    /// Interaction logic for Level4Riddle.xaml
    /// </summary>
    public partial class Level4Riddle : UserControl
    {
        //New timer and media player
        DispatcherTimer t1 = new DispatcherTimer();
        private MediaPlayer media = new MediaPlayer();

        //int used to count timer ticks
        int num = 0;

        public Level4Riddle()
        {
            //play music
            media.Open(new Uri(@"../../Assets/Sound/riddle.m4a", UriKind.Relative));
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
            if (num == 5 || num == 20 || num == 35)
            {
                top.FontSize = top.FontSize + 20;
                //bottom.FontSize = bottom.FontSize + 10;
                //change page at 5 seconds, stop music
            }
            else if (num == 50)
            {
                Switcher.Switch(new Level4());
                t1.Stop();
            }
            //increase tick #
            num++;
        }

    }
}
