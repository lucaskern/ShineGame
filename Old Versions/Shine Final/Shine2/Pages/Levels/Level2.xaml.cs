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
    /// Level 1
    /// </summary>
    public partial class Level2 : UserControl
    {
        //is key in inv
        bool hasKey = false;
        //is inv showing
        bool invShow = false;
        //is rid showing
        bool ridShow = false;

        //media for music and sounds
        MediaPlayer media = new MediaPlayer();
        MediaPlayer m1 = new MediaPlayer();

       

        public Level2()
        {
            InitializeComponent();
            //play ambience sound
            m1.Open(new Uri(@"../../Assets/Sound/ambiance2.m4a", UriKind.Relative));
            m1.Play();
            m1.MediaEnded += new EventHandler(media_Ended);
        }

        //loops audio
        private void media_Ended(object sender, EventArgs e)
        {
            m1.Position = TimeSpan.FromSeconds(0);
            m1.Play();
        }

        //Click key, add to inv and make hidden
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //play grab sound
            media.Open(new Uri(@"../../Assets/Sound/grab2.m4a", UriKind.Relative));
            media.Play();


            //Hide key, register as holding
            key.Visibility = System.Windows.Visibility.Hidden;
            hasKey = true;

            //add key to inventory text
            items.Text = "";
            items.Text = items.Text + "Key";
        }

        //Go to menu
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            media.Stop();
            Switcher.Switch(new Menu());
        }

        //Move on to next level
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            media.Stop();
            m1.Stop();
            Switcher.Switch(new Level3Riddle()); 
        }

        // Drawer Area Click
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            //Only work when the player had picked up the key
            if(hasKey == false)
            {

            } else if (hasKey == true)
            {
                //change image to desk open
                back.Source = new BitmapImage(new Uri(@"../../Assets/deskOpen.png", UriKind.Relative));
                //play drawer sound
                media.Open(new Uri(@"../../Assets/Sound/drawerOpen.m4a", UriKind.Relative));
                media.Play();
                //make letter visible
                letter.Visibility = System.Windows.Visibility.Visible;
            }
        }

        //Inventory open and close toggle
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
          
            if (invShow == false)
            {
                inv.Visibility = System.Windows.Visibility.Visible;
                invShow = true;
            }
            else if (invShow == true)
            {
                inv.Visibility = System.Windows.Visibility.Hidden;
                invShow = false;
            }

        }

        //win state, shtuff
        private void letter_Click(object sender, RoutedEventArgs e)
        {
            winBox.Visibility = System.Windows.Visibility.Visible;

            media.Open(new Uri(@"../../Assets/Sound/solved2.m4a", UriKind.Relative));
            media.Play();
            flash.Visibility = System.Windows.Visibility.Hidden;
        }

        //move flashlight circle
        private void Grid_MouseMove(object sender, MouseEventArgs e)
        {
            circle.Center = e.GetPosition((IInputElement)sender);
        }

        
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            media.Open(new Uri(@"../../Assets/Sound/clock.m4a", UriKind.Relative));
            media.Play();
        }

        //candle
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            media.Open(new Uri(@"../../Assets/Sound/lighter.m4a", UriKind.Relative));
            media.Play();
        }

        //riddle toggle
        private void Button_Click_7(object sender, RoutedEventArgs e)
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
