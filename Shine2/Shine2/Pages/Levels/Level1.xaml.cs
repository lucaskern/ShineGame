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
    /// Interaction logic for Level1.xaml
    /// </summary>
    public partial class Level1 : UserControl
    {
        //bool win = false;
        MediaPlayer media = new MediaPlayer();

        public Level1()
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            media.Stop();
            Switcher.Switch(new Menu());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            media.Stop();
            Switcher.Switch(new Level2Riddle());
        }
    }
}
