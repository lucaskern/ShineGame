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
using Shine2.Pages.Levels;

namespace Shine2.Pages
{
    /// <summary>
    /// A level selection page, clicking a button will switch page to
    /// appropriate content
    /// </summary>
    public partial class LevelSelect : UserControl
    {
      

        public LevelSelect()
        {
            InitializeComponent();
        }

        //Menu
        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
            Switcher.Switch(new Menu());
        }

        //L1
        private void L1_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Level1Riddle());
        }

        //L2
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Level2Riddle());
        }

        //L3
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Level3Riddle());
        }


        //L4
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Level4Riddle());
        }

        //safe test page
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Safe());
        }

        //hazard test page
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new hazard());
        }
        
    }
}
