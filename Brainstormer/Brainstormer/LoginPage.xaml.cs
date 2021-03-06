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

namespace Brainstormer
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {

        public LoginPage()
        {
            InitializeComponent();
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("RegisterPage.xaml", UriKind.Relative));
        }

        private void Bypass_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.isLoggedIn = true;
            NavigationService.Navigate(new Uri("MindMapPage.xaml", UriKind.Relative));
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            if(false)
            {
                Status.Foreground = Brushes.Crimson;
                Status.Text = "Invalid username or password. Try again.";
            }
            else
            {
                MainWindow.isLoggedIn = true;
                NavigationService.Navigate(new Uri("MindMapPage.xaml", UriKind.Relative));
            }
        }
    }
}
