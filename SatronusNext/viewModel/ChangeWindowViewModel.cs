﻿using System;
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
using System.Runtime.CompilerServices;
using Microsoft.Win32;

namespace SatronusNext.viewModel
{
    class ChangeWindowViewModel : DependencyObject , INotifyPropertyChanged
    {
        private Event temp;

        private string changedname;
        public string ChangedName { get { return changedname; } set { changedname = value; OnPropertyChanged(); } }

        private string changedtext;
        public string ChangedText { get { return changedtext; } set { changedtext = value; OnPropertyChanged(); } }

        private DateTime changeddate;
        public DateTime ChangedDate { get { return changeddate; } set { changeddate = value; OnPropertyChanged(); } }

        private string pathtoSound;
        public string PathToSound { get { return pathtoSound; } set { pathtoSound = value; OnPropertyChanged(); } }

        private bool isenablePath;

        public bool IsEnablePath
        {
            get { return isenablePath; }
            set
            {
                isenablePath = value; OnPropertyChanged();
            }
        }

        private ICommand contComm;

        public ICommand ContCommand
        {
            get
            {
                return contComm ?? (contComm = new RelayCommand(() =>
                {
                    // сюда проверку 
                    temp.Name = ChangedName;
                    temp.Text = ChangedText;
                    temp.Time = ChangedDate;
                    if(IsEnablePath)
                    {
                       
                        ((AlarmClock)temp).Music = new System.Media.SoundPlayer(PathToSound);
                        MessageBox.Show(((AlarmClock)temp).Music.SoundLocation);
                    }
                }));
            }
        }

        private ICommand browseComm;

        public ICommand BrowseCommand
        {
            get
            {
                return browseComm ?? (browseComm = new RelayCommand(() =>
                {
                    OpenFileDialog openFile = new OpenFileDialog();
                    openFile.Filter = "Audio Files(*.WAV)|*.WAV";
                    openFile.CheckFileExists = true;
                    openFile.Multiselect = true;
                    if (openFile.ShowDialog() == true && (openFile.FileName.Contains(".WAV") || openFile.FileName.Contains(".wav")))
                    {
                        PathToSound = openFile.FileName;
                    }
                }));
            }
        }

        public ChangeWindowViewModel()
        {
            Messenger.Default.Register<GenericMessage<Event>>(this, SomeFunc);
            //Potoki
        }   
        private void SomeFunc(GenericMessage<Event> msg)
        {
            temp = msg.Content;
            if(temp is Note)
            {
                IsEnablePath = false;
            }
            else
            {
                IsEnablePath = true;
                PathToSound = ((AlarmClock)temp).Music.SoundLocation;
            }
            ChangedName = temp.Name ;
            ChangedText = temp.Text ;
            ChangedDate = temp.Time ;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

    }
}
