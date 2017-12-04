using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для UserInformationWindow.xaml
    /// </summary>
    public partial class UserInformationWindow : Window
    {
        private Program program;

        public UserInformationWindow(Program program)
        {
            this.program = program;
            InitializeComponent();
            Loaded += InitInfo;
        }
        private void InitInfo() { }

        private void InitInfo(object sender, RoutedEventArgs e)
        {
            labelName.Content = program.NameString;
            labelSurname.Content = program.SurnameString;
            lableEMail.Content = program.EMailString;
            if (program.ImageSource != null && program.ImageSource.Length != 0)
            {
                try
                {
                    ImageBrushPhoto.ImageSource = new BitmapImage(new Uri(program.ImageSource, UriKind.Relative));
                }
                catch { }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.FileName = "Image";
            dlg.DefaultExt = ".png|.jpeg";
            dlg.Filter = "Images (.png)|*.png|Images (.jpeg)|*.jpeg";

            Nullable<bool> result = dlg.ShowDialog();

            if (result == true)
            {
                program.ImageSource = dlg.FileName;
                ImageBrushPhoto.ImageSource = new BitmapImage(new Uri(program.ImageSource, UriKind.Relative));
            }
            try
            {
                copyImg();
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("Some problems", "Error " + ex.Message, System.Windows.MessageBoxButton.OK);
            }
        }
        private void copyImg()
        {


        }
    }
}
