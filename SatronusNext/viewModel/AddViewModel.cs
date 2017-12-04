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
using Microsoft.Win32;
using System.Runtime.CompilerServices;

namespace SatronusNext.viewModel
{
    class AddViewModel : DependencyObject , INotifyPropertyChanged
    {
        private ObservableCollection<Event> temp;

        private string addedname;
        public string AddedName { get { return addedname; } set { addedname = value; } }

        private string addedtext;
        public string AddedText { get { return addedtext; } set { addedtext = value; } }

        private DateTime addeddate;
        public DateTime AddedDate { get { return addeddate; } set { addeddate = value; } }

        private string pathtoSound;
        public string PathToSound{ get { return pathtoSound; } set { pathtoSound = value; OnPropertyChanged(); } }

        public int SelectedBoxIndex { get; set; }

        private bool isenablePath=true;

        public bool IsEnablePath { get { return isenablePath; } set { isenablePath = value; OnPropertyChanged();
            } }

        private ICommand contComm;

        public ICommand ContCommand
        {
            get
            {
                return contComm ?? (contComm = new RelayCommand(() =>
                {
                    // сюда проверку 
                    if (IsEnablePath == true)
                    {
                        temp.Add(new AlarmClock(AddedName, AddedDate, AddedText, new System.Media.SoundPlayer(PathToSound)));
                    }
                    else {

                        temp.Add(new Note(AddedName, AddedDate, AddedText));
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
                    if (openFile.ShowDialog()==true && ( openFile.FileName.Contains(".WAV") || openFile.FileName.Contains(".wav")))
                    {
                        PathToSound= openFile.FileName;
                    }
                }));
            }
        }

        private ICommand boxComm;

        public ICommand BoxCommand
        {
            get
            {
                return boxComm ?? (boxComm = new RelayCommand(() =>
                {
                    if(SelectedBoxIndex == 0)
                    {
                        IsEnablePath = true;
                    }
                    else
                    {
                        IsEnablePath = false;
                    }
                }));
            }
        }

        public AddViewModel()
        {
            Messenger.Default.Register<GenericMessage<ObservableCollection<Event>>>(this, SomeFunc);
            //Potoki
        }
        private void SomeFunc(GenericMessage<ObservableCollection<Event>> msg)
        {
            temp = msg.Content;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
