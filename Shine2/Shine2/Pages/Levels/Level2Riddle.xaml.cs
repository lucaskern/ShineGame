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
    /// Interaction logic for Level2Riddle.xaml
    /// </summary>
    public partial class Level2Riddle : UserControl
    {
         DispatcherTimer t1 = new DispatcherTimer();
        private MediaPlayer media = new MediaPlayer();
        int num = 0;
        
        public Level2Riddle()
        {
           

            media.Open(new Uri(@"../../Assets/Sound/riddle.m4a", UriKind.Relative));
            media.Play();
            t1.Interval = TimeSpan.FromSeconds(.1);
            t1.Tick += Timer_Tick;
            t1.Start();
           
            InitializeComponent();
        }

        public void Timer_Tick(object sender, EventArgs e)
        {
            if(num == 5 || num == 20 || num == 35)
            {
                top.FontSize = top.FontSize + 20;
                bottom.FontSize = bottom.FontSize + 10;
            } else if (num == 50) {
                Switcher.Switch(new Level2());
                t1.Stop();
            }
            num++;
        }
    }
}
