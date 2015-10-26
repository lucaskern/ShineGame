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

namespace WPFPageSwitch.Menu
{
    /// <summary>
    /// Interaction logic for Title.xaml
    /// </summary>
    public partial class Title : UserControl
    {
        DispatcherTimer t1 = new DispatcherTimer();

        public Title()
        {
            t1.Interval = TimeSpan.FromSeconds(3);
            t1.Tick += Timer_Tick;
            t1.Start();

            this.InitializeComponent();
        }

        public void Timer_Tick(object sender, EventArgs e)
        {
            Switcher.Switch(new Menu());
            t1.Stop();
        }
    }
}
