<<<<<<< HEAD
﻿using System;
=======
﻿using SheckSheck_Kiosk.Home;
using System;
>>>>>>> feat/home
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

namespace SheckSheck_Kiosk
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
<<<<<<< HEAD
=======
            HomePage homePage = new HomePage();
            this.Content = homePage;
>>>>>>> feat/home
        }
    }
}
