﻿using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
namespace SDP
{
    public partial class Login : PhoneApplicationPage
    {
        public Login()
        {
           
            InitializeComponent();
            MainPage.is_NewInstance = true;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Username_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Reg_Event(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Register.xaml", UriKind.Relative));
        }

        private void Login_Event(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new Uri("/UserDashBoard.xaml", UriKind.Relative));
        }

        private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}