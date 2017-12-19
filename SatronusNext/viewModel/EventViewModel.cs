using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Data;
using System.ComponentModel﻿;
 using GalaSoft.MvvmLight.Command;
using SatronusNext.eventType;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight.Messaging;
using System.Threading;
using System.Windows.Threading;

namespace SatronusNext.viewModel
{
    class EventViewModel : DependencyObject
    {
        private Event selectedEvent;
        public Event SelectedEvent { get { return selectedEvent; } set { selectedEvent = value; } }

        SerialData Data = new SerialData();

        List<Event> ListofNearCalls;
        private DispatcherTimer timer = null;

        private void timerStart()
        {
            timer = new DispatcherTimer();  // если надо, то в скобках указываем приоритет, например DispatcherPriority.Render
            timer.Tick += new EventHandler(ShowMagic);
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start();
        //    Console.WriteLine("Thread2on :{0}", Thread.CurrentThread.ManagedThreadId);
        }

        private void timerNearStart()
        {
            timer = new DispatcherTimer();  // если надо, то в скобках указываем приоритет, например DispatcherPriority.Render
            timer.Tick += new EventHandler(NearEvents);
            timer.Interval = new TimeSpan(0, 30, 0);
            timer.Start();
            //    Console.WriteLine("Thread2on :{0}", Thread.CurrentThread.ManagedThreadId);
        }
        /*
        ObservableCollection<Event> list;
        public ObservableCollection<Event> OurList { get { return list; } private set { list = value; } }

        */
        public string FilterText
       {
           get { return (string)GetValue(FilterTextProperty); }
           set { SetValue(FilterTextProperty, value); }
       }
       // Using a DependencyProperty as the backing store for FilterText.  This enables animation, styling, binding, etc...
       public static readonly DependencyProperty FilterTextProperty =
           DependencyProperty.Register("FilterText", typeof(string), typeof(EventViewModel), new PropertyMetadata("" ,Filter_Change));

       private static void Filter_Change(DependencyObject d, DependencyPropertyChangedEventArgs e)
       {
           var current = d as EventViewModel;
           if(current != null)
           {
               current.Items.Filter = null;
               current.Items.Filter = current.FilterEvent;
           }
       }

       public ICollectionView Items
       {
           get { return (ICollectionView)GetValue(ItemsProperty); }
           set { SetValue(ItemsProperty, value); }
       }

       // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
       public static readonly DependencyProperty ItemsProperty =

           DependencyProperty.Register("MyProperty", typeof(ICollectionView), typeof(EventViewModel), new PropertyMetadata(null));
           
        public  EventViewModel()
        {
            Data.OurList = new ObservableCollection<Event> { 
            new AlarmClock("Будильник 2",new DateTime(2018,12,12,17,50,00),"txt",new System.Media.SoundPlayer(@"3194.wav")),
            new AlarmClock("Будильник 3",new DateTime(2017,12,18,14,35,00),"txt",new System.Media.SoundPlayer(@"Resources/zvyk.wav")),
            new AlarmClock("Pfvtnrf",new DateTime(2017,12,18,13,26,00),"txt",new System.Media.SoundPlayer(@"Resources/zvyk.wav")),
              new AlarmClock("Pfvtnrf",new DateTime(2013,12,12,12,16,00),"txt",new System.Media.SoundPlayer(@"Resources/zvyk.wav")),
                new AlarmClock("Pfvtnrf",new DateTime(2014,12,12,12,16,00),"txt",new System.Media.SoundPlayer(@"Resources/zvyk.wav")),
            new AlarmClock("Заметка 3", new DateTime(2000,12,12,18,12,00) ,"txt",new System.Media.SoundPlayer(@"Resources/zvyk.wav")) };
             Data.Sort();

            this.NearEvents(null,null);
        
            this.timerStart();
            this.timerNearStart();
            Items = CollectionViewSource.GetDefaultView(Data.OurList);
            Items.Filter = FilterEvent;
        }


        public async  void NearEvents(object sender, EventArgs e)
        {
           ListofNearCalls = await Data.NearCalls();

        }
        private async void ShowMagic(object sender, EventArgs e)
        {
            Event temp=null;
           await Task.Factory.StartNew(() =>
            {
                if (ListofNearCalls != null && ListofNearCalls.Count!=0)
                {
                    for (int i = 0; i < ListofNearCalls.Count; i++)
                    {
                    if (ListofNearCalls[i].Time.Date == DateTime.Now.Date &&
                            ListofNearCalls[i].Time.TimeOfDay.Hours == DateTime.Now.Hour &&
                             ListofNearCalls[i].Time.TimeOfDay.Minutes == DateTime.Now.Minute)
                         {
                            temp = ListofNearCalls[i];
                            ListofNearCalls.Remove(temp);
                            Data.DeleteEvent(temp);
                            return;
                         }
                    }
                }
            });
            if(temp !=null)
            {
                NotificationWindow qew = new NotificationWindow(temp);
                qew.Show();
            }
        }
        private bool FilterEvent(object obj)
        {
            bool result = true;
           Event temp = obj as Event;
            if(!string.IsNullOrWhiteSpace(FilterText) && temp!=null && !temp.Name.Contains(FilterText) && !temp.Time.ToString().Contains(FilterText))
            {
                result = false;
            }
            return result;
        }        
        private ICommand delComm;

        public ICommand DeleteCommand {
            get {
                return delComm ?? (delComm = new RelayCommand(() =>
                {
                    if (SelectedEvent == null)
                    {
                        return;
                    }
                    else
                    {
                        ListofNearCalls.Remove(SelectedEvent);
                        Data.OurList.Remove(SelectedEvent);
                    }
                }));
            }
        }
        private ICommand changeComm;

        public ICommand ChangeCommand
        {
            get
            {
                return changeComm ?? (changeComm = new RelayCommand(() =>
                {
                    if (SelectedEvent == null)
                    {
                        return;
                    }
                    Messenger.Default.Send(new GenericMessage<Event>(selectedEvent));
                    Messenger.Default.Send(new GenericMessage<SerialData>(Data));
                    Messenger.Default.Send(new GenericMessage<List<Event>>(ListofNearCalls));
                }));
            }
        }

        private ICommand addComm;

        public ICommand AddCommand
        {
            get
            {
                return addComm ?? (addComm = new RelayCommand(() =>
                {
                    Messenger.Default.Send(new GenericMessage<SerialData>(Data));
                    Messenger.Default.Send(new GenericMessage<List<Event>>(ListofNearCalls));
                }));
            }
        }
    }
}
