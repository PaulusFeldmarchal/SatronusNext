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

namespace SatronusNext.viewModel
{
    class EventViewModel : DependencyObject
    {
      
        private Event selectedEvent;
        public Event SelectedEvent { get { return selectedEvent; } set { selectedEvent = value; } }


        ObservableCollection<Event> list;
        public ObservableCollection<Event> OurList { get { return list; } private set { list = value; } }

        
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
           
        public EventViewModel()
        {
            OurList = new ObservableCollection<Event> { new Note("Заметка 1",DateTime.Now,"txt"),
            new Note("Заметка 2",DateTime.Now,"txt"),
            new Note("Заметка 3", DateTime.Now,"txt"),
            new Note("Заметка 4",DateTime.Now,"txt"),
            new AlarmClock("Будильник 1",DateTime.Now,"txt",null),
            new AlarmClock("Будильник 2",DateTime.Now,"txt",null),
            new AlarmClock("Будильник 3",DateTime.Now,"txt",null),
            new AlarmClock("Будильник 4",DateTime.Now,"txt",null) };
            Items = CollectionViewSource.GetDefaultView(OurList);
            Items.Filter = FilterEvent;
            
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
                        OurList.Remove(SelectedEvent);
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
                    Messenger.Default.Send(new GenericMessage<ObservableCollection<Event>>(OurList));
                }));
            }
        }
    }
}
