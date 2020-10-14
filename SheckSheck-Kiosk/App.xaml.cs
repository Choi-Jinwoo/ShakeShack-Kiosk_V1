using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace SheckSheck_Kiosk
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        DateTime StartTime = DateTime.Now;
        private void Application_Exit(object sender, ExitEventArgs e)
        {
            DateTime EndTime = DateTime.Now;
            String RunTime = (EndTime - StartTime).ToString("h'시 'm'분 's'초'");
            MessageBox.Show("프로그램 구동 시간 : " + RunTime);
        }
    }
}
