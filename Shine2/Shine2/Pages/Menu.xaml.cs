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
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : UserControl
    {
        //media player
        public MediaPlayer m1 = new MediaPlayer();

        public Menu()
        {
            InitializeComponent();

            //Play song, call method to repeat when song ends
            m1.Open(new Uri(@"../../Assets/Sound/song1.m4a", UriKind.Relative));
            m1.Play();
            m1.MediaEnded += new EventHandler(media_Ended);
        }

        //loops audio
        private void media_Ended(object sender, EventArgs e)
        {
            m1.Position = TimeSpan.FromSeconds(0);
            m1.Play();
        }

        //stop audio and open level select
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            m1.Stop();
            Switcher.Switch(new LevelSelect());
        }

        //stop audio and begin Level 1
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           m1.Stop();
           //must specify the levels folder when going from a page in Menu to a page in Levels
           Switcher.Switch(new Levels.Level1Riddle());
        }
    }
}
