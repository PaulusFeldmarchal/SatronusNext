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
using SatronusNext.viewModel;
using SatronusNext.eventType;
using System.ComponentModel;

namespace SatronusNext
{

    /// <summary>
    /// Логика взаимодействия для ProgramWindow.xaml
    /// </summary>
    public partial class ProgramWindow : Window
    {
        public Program program { get; set; }
        public ProgramWindow()
        {
            InitializeComponent();
        }
  
        private void ChangeClick(object sender, RoutedEventArgs e)
        {
            ChangeWindow changeWindow = new ChangeWindow();
            changeWindow.Show();
        }

        private void AddClick(object sender, RoutedEventArgs e)
        {
            AddWindow addWindow = new AddWindow();
            addWindow.Show();
        }

        private void UserInformationButton_Click(object sender, RoutedEventArgs e)
        {
            UserInformationWindow usrWind = new UserInformationWindow(program);
            usrWind.Show();
        }

        private void InformButton_Click(object sender, RoutedEventArgs e)
        {
            AboutWindow about = new AboutWindow();
            about.Show();
        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            Log.DeleteSesion();
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}
