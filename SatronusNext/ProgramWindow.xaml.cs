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

namespace SatronusNext
{
    public class Event
    {
        public string Name { get; set; }
        public DateTime Time { get; set; }
        public Event() { Time = DateTime.Now; }
        public Event(string name,DateTime time)
        {
            Time = time;
            Name = name;
        }
    }
    /// <summary>
    /// Логика взаимодействия для ProgramWindow.xaml
    /// </summary>
    public partial class ProgramWindow : Window
    {
        public ProgramWindow()
        {
            InitializeComponent();
            Loaded += ProgramWindow_Loaded;
        }

        private void ProgramWindow_Loaded(object sender, RoutedEventArgs e)
        {
            Event[] mass = new Event[]{
            new Event("Будильник 1",DateTime.Now), 
            new Event("Будильник 2",DateTime.Now), 
            new Event("Будильник 3", DateTime.Now),
             new Event("Будильник 1",DateTime.Now),
            new Event("Будильник 2",DateTime.Now),
            new Event("Будильник 3", DateTime.Now),
             new Event("Будильник 1",DateTime.Now),
            new Event("Будильник 2",DateTime.Now),
            new Event("Будильник 3", DateTime.Now)

                };
            DataContext = new EventViewModel(mass);

        }
    }
}
