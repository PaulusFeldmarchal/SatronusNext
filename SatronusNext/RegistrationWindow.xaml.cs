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
using System.Windows.Shapes;

namespace SatronusNext
{
    /// <summary>
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        private string passwordText { get; set; }
        private Program program = new Program();

        public RegistrationWindow()
        {
            InitializeComponent();
        }
        private void buttonExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void tryToregisterButton_Click(object sender, RoutedEventArgs e)
        {
            bool check = false;
            if (registrationSurnameTextBox.Text.Length == 0)
            {
                registSurnameAlertImg.Visibility = System.Windows.Visibility.Visible;
                check = true;
            }
            if (registrationNameTextBox.Text.Length == 0)
            {
                registNameAlertImg.Visibility = System.Windows.Visibility.Visible;
                check = true;
            }
            if (registrationEMailTextBox.Text.Length == 0 || !registrationEMailTextBox.Text.Contains("@"))
            {
                registEMailAlertImg.Visibility = System.Windows.Visibility.Visible;
                check = true;
            }
            if (registrationPasswordBox.Password.Length == 0)
            {
                registPasswordAlertImg.Visibility = System.Windows.Visibility.Visible;
                check = true;
            }
            if (registrationRetryPasswordBox.Password != registrationPasswordBox.Password)
            {
                registRetryAlertImg.Visibility = System.Windows.Visibility.Visible;
                check = true;
            }
            if (check)
                return;
            program.NameString = registrationNameTextBox.Text;
            program.SurnameString = registrationSurnameTextBox.Text;
            program.EMailString = registrationEMailTextBox.Text;
            program.PasswordString = registrationRetryPasswordBox.Password;
            if (program.tryToRegist())
            {
                ProgramWindow programWindow = new ProgramWindow();
                programWindow.program = program;
                programWindow.Show();
                this.Close();
            }
        }

        private void backinMainMenuButton1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void registrationNameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (registrationNameTextBox.Text.Length == 0)
                registNameAlertImg.Visibility = System.Windows.Visibility.Visible;
            else
                registNameAlertImg.Visibility = System.Windows.Visibility.Hidden;
        }

        private void registrationSurnameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (registrationSurnameTextBox.Text.Length == 0)
                registSurnameAlertImg.Visibility = System.Windows.Visibility.Visible;
            else
                registSurnameAlertImg.Visibility = System.Windows.Visibility.Hidden;
        }

        private void registrationEMailTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (registrationEMailTextBox.Text.Length == 0 || !registrationEMailTextBox.Text.Contains("@"))
                registEMailAlertImg.Visibility = System.Windows.Visibility.Visible;
            else
                registEMailAlertImg.Visibility = System.Windows.Visibility.Hidden;
        }

        private void registrationPasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (registrationPasswordBox.Password.Length == 0)
                registPasswordAlertImg.Visibility = System.Windows.Visibility.Visible;
            else
                registPasswordAlertImg.Visibility = System.Windows.Visibility.Hidden;
        }

        private void registrationRetryPasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (registrationRetryPasswordBox.Password != registrationPasswordBox.Password)
                registRetryAlertImg.Visibility = System.Windows.Visibility.Visible;
            else
                registRetryAlertImg.Visibility = System.Windows.Visibility.Hidden;
        }
    }
}
