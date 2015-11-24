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
    /// Interaction logic for Level2.xaml
    /// </summary>
    public partial class Level3 : UserControl
    {
        //bool used to determine if the player has won (unused)
        //bool win = false;
        private MediaPlayer media = new MediaPlayer();

        public Level3()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // win = true;
            media.Open(new Uri(@"../../Assets/Sound/solved2.m4a", UriKind.Relative));
            media.Play();

            winBox.Visibility = System.Windows.Visibility.Visible;
        }

        //Go to next level
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            media.Stop();
            Switcher.Switch(new Menu());
        }

        //Go to menu
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            media.Stop();
            Switcher.Switch(new Level4Riddle());
            
        }
       
    }
}
