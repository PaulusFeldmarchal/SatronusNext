using GalaSoft.MvvmLight.Messaging;
using SatronusNext.eventType;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SatronusNext
{

    public partial class NotificationWindow : Window
    {
       public Event CalledEvent;
        string qwerty="we";
        public string EventName { get { return qwerty; } set { qwerty = value; OnPropertyChanged(); } }
        DoubleAnimation anim;
        int left;
        int top;
        DependencyProperty prop;
        int end;
        public NotificationWindow(Event temp)
        {

            InitializeComponent();
            EventText.Text = temp.Text;
            Title = temp.Name;
            if(temp is Note)
            {
                BackgroundImage.Source = new BitmapImage(new Uri("Resources/pen.jpg", UriKind.Relative));
            }
            else
            {
                BackgroundImage.Source = new BitmapImage(new Uri("Resources/alarmback.jpg", UriKind.Relative));
                AlarmClock alarm = temp as AlarmClock;
                try {
                    alarm.Music.Play();
                }catch(Exception ex)
                {
                    try
                    {
                        alarm.Music.SoundLocation = @"Resources/standart.wav";
                        alarm.Music.Play();
                    }
                    catch(Exception exeption)
                    {
                        MessageBox.Show(exeption.Message);
                   }
                }
            }
            TrayPos tpos = new TrayPos();
            tpos.getXY((int)this.Width, (int)this.Height, out top, out left, out prop, out end);
            this.Top = top;
            this.Left = left;
            anim = new DoubleAnimation(end, TimeSpan.FromSeconds(1));
        }
        public NotificationWindow()
        {

            InitializeComponent();
            TrayPos tpos = new TrayPos();
            tpos.getXY((int)this.Width, (int)this.Height, out top, out left, out prop, out end);
            this.Top = top;
            this.Left = left;
            anim = new DoubleAnimation(end, TimeSpan.FromSeconds(1));
        }
        private void NotificationLoaded(object sender, RoutedEventArgs e)
        {
            AnimationClock clock = anim.CreateClock();
            this.ApplyAnimationClock(prop, clock);
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
