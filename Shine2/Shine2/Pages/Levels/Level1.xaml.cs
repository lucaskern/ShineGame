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

namespace Shine2.Pages.Levels
{
    /// <summary>
    /// Interaction logic for Level3.xaml
    /// </summary>
    public partial class Level1 : UserControl
    {
        DispatcherTimer t1 = new DispatcherTimer();

        public Level1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            open.Visibility = System.Windows.Visibility.Visible;

            t1.Interval = TimeSpan.FromSeconds(2.0);
            t1.Start();

            t1.Tick += Timer_Tick;

            
        }

        public void Timer_Tick(object sender, EventArgs e)
        {
            Switcher.Switch(new Level2Riddle());
            t1.Stop();
        }
    }
}
