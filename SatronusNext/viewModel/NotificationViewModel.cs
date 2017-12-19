using GalaSoft.MvvmLight.Messaging;
using SatronusNext.eventType;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SatronusNext.viewModel
{
    class NotificationViewModel
    {
        string eventName = "we";
        public string EventName { get { return eventName; } set { eventName = value; OnPropertyChanged(); } }
        Event CallingEvent;

        public NotificationViewModel()
        {
            Console.WriteLine("1");
            Messenger.Default.Register<GenericMessage<Event>>(this, SomeFunc);
            Console.WriteLine("3");
            eventName = "w123eq";
        }
        private void SomeFunc(GenericMessage<Event> msg)
        {
            Console.WriteLine("2");
            CallingEvent = msg.Content;
            if (CallingEvent ==null)
            {
                Console.WriteLine("qweweqewq");
            }
            EventName = CallingEvent.Name;
            Console.WriteLine(EventName);
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
