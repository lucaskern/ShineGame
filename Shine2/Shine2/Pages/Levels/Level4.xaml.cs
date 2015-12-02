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

namespace Shine2.Pages.Levels
{
    /// <summary>
    /// Interaction logic for Level4.xaml
    /// </summary>
    public partial class Level4 : UserControl
    {
        // ambience/music
        MediaPlayer m1 = new MediaPlayer();

        bool ridShow = false;

        public Level4()
        {
            InitializeComponent();
            m1.Open(new Uri(@"../../Assets/Sound/ambience.m4a", UriKind.Relative));
            m1.Play();
            m1.MediaEnded += new EventHandler(media_Ended);
        }
        //loops audio
        private void media_Ended(object sender, EventArgs e)
        {
            m1.Position = TimeSpan.FromSeconds(0);
            m1.Play();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Safe());
            m1.Stop();
        }

        private void Grid_MouseMove(object sender, MouseEventArgs e)
        {
            circle.Center = e.GetPosition((IInputElement)sender);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (ridShow == false)
            {
                rid.Visibility = System.Windows.Visibility.Visible;
                ridShow = true;
            }
            else if (ridShow == true)
            {
                rid.Visibility = System.Windows.Visibility.Hidden;
                ridShow = false;
            }
        }
    }
}
