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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Menu());
        }

        private void L1_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Level1Riddle());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Level2Riddle());
        }
    }
}
