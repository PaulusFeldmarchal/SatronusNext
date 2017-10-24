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

namespace SatronusNext
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void singInButton_Click(object sender, RoutedEventArgs e)
        {
            ProgramWindow programWindow = new ProgramWindow();
            programWindow.Show();
            this.Hide();

        }

        private void signUpButton_Click(object sender, RoutedEventArgs e)
        {
            logo.Visibility = System.Windows.Visibility.Hidden;
            passwordBox.Visibility = System.Windows.Visibility.Hidden;
            emailTextBox.Visibility = System.Windows.Visibility.Hidden;
            emailLabel.Visibility = System.Windows.Visibility.Hidden;
            passwordLabel.Visibility = System.Windows.Visibility.Hidden;
            signUpButton.Visibility = System.Windows.Visibility.Hidden;
            singInButton.Visibility = System.Windows.Visibility.Hidden;

            backinMainMenuButton1.Visibility = System.Windows.Visibility.Visible;
            tryToregisterButton.Visibility = System.Windows.Visibility.Visible;
            logoOnRegistration.Visibility = System.Windows.Visibility.Visible;
            registrationLabel.Visibility = System.Windows.Visibility.Visible;
            registrationNameLabel.Visibility = System.Windows.Visibility.Visible;
            registrationSurnameLabel.Visibility = System.Windows.Visibility.Visible;
            registrationEMailTextBox.Visibility = System.Windows.Visibility.Visible;
            registrationPasswordLabel.Visibility = System.Windows.Visibility.Visible;
            registrationRetryLabel.Visibility = System.Windows.Visibility.Visible;
            registrationNameTextBox.Visibility = System.Windows.Visibility.Visible;
            registrationSurnameTextBox.Visibility = System.Windows.Visibility.Visible;
            registrationEMailLabel.Visibility = System.Windows.Visibility.Visible;
            registrationPasswordBox.Visibility = System.Windows.Visibility.Visible;
            registrationRetryPasswordBox.Visibility = System.Windows.Visibility.Visible;

        }

        private void backinMainMenuButton1_Click(object sender, RoutedEventArgs e)
        {
            logo.Visibility = System.Windows.Visibility.Visible;
            passwordBox.Visibility = System.Windows.Visibility.Visible;
            emailTextBox.Visibility = System.Windows.Visibility.Visible;
            emailLabel.Visibility = System.Windows.Visibility.Visible;
            passwordLabel.Visibility = System.Windows.Visibility.Visible;
            signUpButton.Visibility = System.Windows.Visibility.Visible;
            singInButton.Visibility = System.Windows.Visibility.Visible;

            backinMainMenuButton1.Visibility = System.Windows.Visibility.Hidden;
            tryToregisterButton.Visibility = System.Windows.Visibility.Hidden;
            logoOnRegistration.Visibility = System.Windows.Visibility.Hidden;
            registrationLabel.Visibility = System.Windows.Visibility.Hidden;
            registrationNameLabel.Visibility = System.Windows.Visibility.Hidden;
            registrationSurnameLabel.Visibility = System.Windows.Visibility.Hidden;
            registrationEMailTextBox.Visibility = System.Windows.Visibility.Hidden;
            registrationPasswordLabel.Visibility = System.Windows.Visibility.Hidden;
            registrationRetryLabel.Visibility = System.Windows.Visibility.Hidden;
            registrationNameTextBox.Visibility = System.Windows.Visibility.Hidden;
            registrationSurnameTextBox.Visibility = System.Windows.Visibility.Hidden;
            registrationEMailLabel.Visibility = System.Windows.Visibility.Hidden;
            registrationPasswordBox.Visibility = System.Windows.Visibility.Hidden;
            registrationRetryPasswordBox.Visibility = System.Windows.Visibility.Hidden;
        }

        private void tryToregisterButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
