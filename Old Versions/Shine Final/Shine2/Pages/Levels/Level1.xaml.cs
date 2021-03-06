﻿using System;
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
    /// Interaction logic for Level3.xaml
    /// </summary>
    public partial class Level1 : UserControl
    {
        //timer
        DispatcherTimer t1 = new DispatcherTimer();
        //music and ambience tracks
        MediaPlayer m1 = new MediaPlayer();
        //environmental/onclick sounds
        MediaPlayer media = new MediaPlayer();

        //is the riddle context menu open
        bool ridShow = false;

        //play music
        public Level1()
        {
            InitializeComponent();
            m1.Open(new Uri(@"../../Assets/Sound/ambience.m4a", UriKind.Relative));
            m1.Play();
            //on music end, call looping method
            m1.MediaEnded += new EventHandler(media_Ended);
        }

        //loops audio
        private void media_Ended(object sender, EventArgs e)
        {
            m1.Position = TimeSpan.FromSeconds(0);
            m1.Play();
        }

        //door click, load opened door image and start 2 second timer
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            open.Visibility = System.Windows.Visibility.Visible;

            t1.Interval = TimeSpan.FromSeconds(2);
            t1.Start();

            m1.Open(new Uri(@"../../Assets/Sound/door.m4a", UriKind.Relative));
            m1.Play();

            t1.Tick += Timer_Tick;
            
        }

        //Door open sound is over, win state
        public void Timer_Tick(object sender, EventArgs e)
        {
            winBox.Visibility = System.Windows.Visibility.Visible;
            flash.Visibility = System.Windows.Visibility.Hidden; 
            t1.Stop();
            m1.Stop();

            media.Open(new Uri(@"../../Assets/Sound/solved2.m4a", UriKind.Relative));
            media.Play();
        }

        //move flashlight circle
        private void Grid_MouseMove(object sender, MouseEventArgs e)
        {
            circle.Center = e.GetPosition((IInputElement)sender);
        }

        //go to level 2
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Level2Riddle());
        }

        //got to menu
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Menu());
        }

        //riddle toggle
        private void Button_Click_3(object sender, RoutedEventArgs e)
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
