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
using System.Windows.Shapes;

namespace _4._5_Eventos_pt2
{
    /// <summary>
    /// Interaction logic for MainAppWindow.xaml
    /// </summary>
    public partial class MainAppWindow : Window
    {
        public MainAppWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new PrincipalPage(this));
        }
    }
}
