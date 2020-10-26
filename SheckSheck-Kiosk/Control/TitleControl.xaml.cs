using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

namespace SheckSheck_Kiosk.Control
{
    /// <summary>
    /// TitleControl.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class TitleControl : UserControl
    {
        public TitleControl()
        {
            InitializeComponent();
            lbClock.Content = DateTime.Now.ToString();
            Loaded += TitleControl_Loaded;
        }

        private void TitleControl_Loaded(object sender, RoutedEventArgs e)
        {
            SetClockEvent();
        }

        private void SetClockEvent()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Tick += new EventHandler((object sender, EventArgs e) => {
                lbClock.Content = DateTime.Now.ToString();
            });
            timer.Start();
        }

        private void btnHomePage_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Page 전환
        }
    }
}
