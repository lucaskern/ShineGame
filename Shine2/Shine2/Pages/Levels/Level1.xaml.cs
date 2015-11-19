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
    public partial class Level1 : UserControl
    {
        //bool used to determine if the player has won (unused)
        //bool win = false;
        bool hasKey = false;
        bool invShow = false;
        MediaPlayer media = new MediaPlayer();

       

        public Level1()
        {
            InitializeComponent();
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
            Switcher.Switch(new Level2Riddle());
        }

        // Drawer Area Click
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            //Only work when the player had picked up the key
            if(hasKey == false)
            {

            } else if (hasKey == true)
            {
                //open the win menu and play tune
                winBox.Visibility = System.Windows.Visibility.Visible;
             
                media.Open(new Uri(@"../../Assets/Sound/solved2.m4a", UriKind.Relative));
                media.Play();
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
    }
}
