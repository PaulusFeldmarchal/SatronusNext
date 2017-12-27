using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
        private Program program;

        public MainWindow()
        {

            InitializeComponent();
            program = Log.Deserialization();
            if (program != null)
            {
                //Task<bool> task = ConnectToServer.TryToSignInAsync();
                /*if (task.Result)
                {
                    ProgramWindow programWindow = new ProgramWindow
                    {
                        program = program
                    };
                    programWindow.Show();
                    this.Close();
                }*/
            }

        }

        private void buttonExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void singInButton_Click(object sender, RoutedEventArgs e)
        {
           /* if (emailTextBox.Text.Length != 0 && emailTextBox.Text.Contains("@") && passwordBox.Password.Length != 0)
            {//*/
                // make some smarter then now
                program = new Program();
                program.EMailString = emailTextBox.Text;
                program.PasswordString = passwordBox.Password;
                Task<bool> task = ConnectToServer.TryToSignInAsync(program.EMailString, program.PasswordString);
                Thread myThread = new Thread(new ThreadStart());
                myThread.Start();
           /* if (task.Result)
                {//*/
                    ProgramWindow programWindow = new ProgramWindow();
                    programWindow.program = program;
                    Log.Serialization(program);
                    programWindow.Show();
                    this.Close();
               // }
            //}
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
