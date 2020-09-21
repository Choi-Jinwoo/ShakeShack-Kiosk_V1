﻿using System;
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

namespace SheckSheck_Kiosk.Order
{
    /// <summary>
    /// OrderControl.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class OrderControl : UserControl
    {
        public OrderControl()
        {
            InitializeComponent();
            clock.Content = DateTime.Now.ToString();
            setClockEvent();
        }

        /// <summary>
        /// Clock의 이벤트 설정
        /// </summary>
        private void setClockEvent()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Tick += new EventHandler((object sender, EventArgs e) => {
                clock.Content = DateTime.Now.ToString();
            });
            timer.Start();
        }

    }
}
