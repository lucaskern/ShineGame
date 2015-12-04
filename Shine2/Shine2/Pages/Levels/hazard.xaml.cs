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
    /// Interaction logic for hazard.xaml
    /// </summary>
    public partial class hazard : UserControl
    {
        DispatcherTimer t1 = new DispatcherTimer();

        MediaPlayer media = new MediaPlayer();


        public hazard()
        {   
            InitializeComponent();

            //play music
            media.Open(new Uri(@"../../Assets/Sound/snore.m4a", UriKind.Relative));
            media.Play();

            media.MediaEnded += new EventHandler(media_Ended);

        }

        //go to alert stage
        private void Image_MouseEnter(object sender, MouseEventArgs e)
        {
            media.Stop();

            //play music
            media.Open(new Uri(@"../../Assets/Sound/alert.m4a", UriKind.Relative));
            media.Play();


            t1.Interval = TimeSpan.FromSeconds(3.0);
            t1.Start();

            t1.Tick += Timer_Tick;
            guy.Source = new BitmapImage(new Uri(@"../../Assets/alert.png", UriKind.Relative));
        }

        private void guy_MouseLeave(object sender, MouseEventArgs e)
        {
            media.Stop();

            //play music
            media.Open(new Uri(@"../../Assets/Sound/snore.m4a", UriKind.Relative));
            media.Play();

            media.MediaEnded += new EventHandler(media_Ended);

            t1.Stop();
            guy.Source = new BitmapImage(new Uri(@"../../Assets/happy.png", UriKind.Relative));
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            media.Stop();

            //play music
            media.Open(new Uri(@"../../Assets/Sound/mad.m4a", UriKind.Relative));
            media.Play();

            guy.Source = new BitmapImage(new Uri(@"../../Assets/mad.png", UriKind.Relative));
        }

        //move flashlight circle
        private void Grid_MouseMove(object sender, MouseEventArgs e)
        {
            circle.Center = e.GetPosition((IInputElement)sender);
        }

        //loops audio
        private void media_Ended(object sender, EventArgs e)
        {
            media.Position = TimeSpan.FromSeconds(0);
            media.Play();
        }
    }
}
