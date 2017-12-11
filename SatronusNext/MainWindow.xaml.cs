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

namespace SatronusNext
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static private Program program = new Program();

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
            if (emailTextBox.Text.Length != 0 && emailTextBox.Text.Contains("@") && passwordBox.Password.Length != 0)
            {
                // make some smarter then now
                program.EMailString = emailTextBox.Text;
                program.PasswordString = passwordBox.Password;
                if (program.tryToSignIn())
                {
                    ProgramWindow programWindow = new ProgramWindow();
                    programWindow.program = program;
                    programWindow.Show();
                    this.Close();
                }
            }
        }

        private void signUpButton_Click(object sender, RoutedEventArgs e)
        {
            RegistrationWindow registrationWindow = new RegistrationWindow();
            registrationWindow.Show();
            this.Close();
        }

        private void emailTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (emailTextBox.Text.Length == 0 || !emailTextBox.Text.Contains("@"))
                EMailAlertImg.Visibility = System.Windows.Visibility.Visible;
            else
                EMailAlertImg.Visibility = System.Windows.Visibility.Hidden;
        }

        private void passwordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (passwordBox.Password.Length == 0)
                PasswordlAlertImg.Visibility = System.Windows.Visibility.Visible;
            else
                PasswordlAlertImg.Visibility = System.Windows.Visibility.Hidden;
        }
    }
}
