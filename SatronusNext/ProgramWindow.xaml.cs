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
            Loaded += ProgramWindow_Loaded;
        }
        /*
        protected override void OnStateChanged(EventArgs e)
        {
            if (WindowState == WindowState.Minimized) this.Hide();

            
            base.OnStateChanged(e);
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            // setting cancel to true will cancel the close request
            // so the application is not closed
            e.Cancel = true;

            this.Hide();

            base.OnClosing(e);
        }
        */

        private void ProgramWindow_Loaded(object sender, RoutedEventArgs e)
        {
           

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
    }
}
