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

namespace _4._5_Eventos_pt2
{
    /// <summary>
    /// Interaction logic for PrincipalPage.xaml
    /// </summary>
    public partial class PrincipalPage : Page
    {
        private MainAppWindow _mainWindow;
        public PrincipalPage(MainAppWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }
        private void GoToSecondary_Click(object sender, RoutedEventArgs e)
        {
            _mainWindow.MainFrame.Navigate(new SecondaryPage(_mainWindow));
        }
    }
}
