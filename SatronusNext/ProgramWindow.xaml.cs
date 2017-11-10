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

namespace SatronusNext
{

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
            AbstractEvent[] mass = new AbstractEvent[]{
            new NoteEvent("Будильник 1",DateTime.Now), 
            new NoteEvent("Будильник 2",DateTime.Now), 
            new NoteEvent("Будильник 3", DateTime.Now),
            new NoteEvent("Будильник 1",DateTime.Now),
            new NoteEvent("Будильник 2",DateTime.Now),
            new NoteEvent("Будильник 3", DateTime.Now),
            new NoteEvent("Будильник 1",DateTime.Now),
            new NoteEvent("Будильник 2",DateTime.Now),
            new NoteEvent("Будильник 3", DateTime.Now)

                };
            DataContext = new EventViewModel(mass);

        }
    }
}
