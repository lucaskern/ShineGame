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

namespace Shine2.Pages
{
    /// <summary>
    /// Interaction logic for LevelSelect.xaml
    /// </summary>
    public partial class LevelSelect : UserControl
    {
        public LevelSelect()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Menu());
        }

        private void L1_Click(object sender, RoutedEventArgs e)
        {
           // Switcher.Switch(new L1Riddle());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           // Switcher.Switch(new L2Riddle());
        }
    }
}
