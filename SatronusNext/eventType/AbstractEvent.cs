using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GalaSoft.MvvmLight;
namespace SatronusNext.eventType
{
   public  abstract class Event : ObservableObject
    {
            string picturepath;
            DateTime time;
            bool repeat;
        string name;
        string text;
        public string PathPicture { get { return picturepath; }
            set {
                if (value == null)
                {
                    //exeption
                }
                picturepath = value; // для начала
                RaisePropertyChanged(() => PathPicture);
            }
        }
        public string Name { get { return name; }
            set {
                name = value;
                RaisePropertyChanged(() => Name);
            }
        }
        public string Text
        {
            get { return text; }
            set
            {
                text = value;
                RaisePropertyChanged(() => Text);
            }
        }
        public DateTime Time
        {
            get { return time; }
            set
            {
                time = value; // для начала
                if (value == null)
                {
                    //exeption
                }
                RaisePropertyChanged(() => Time);
            }
        }
            public Event() {
            Time = DateTime.Now;//временно
        }
            public Event(string name, string text, DateTime time)
            {
                Time = time;
                Name = name;
                Text = text;
            }
        //override
        public override string ToString()
        {
          return  String.Format("Name of event :{1} Text of event : {2} Date : {3}", Name, Text, Time.ToString());
        }
        public virtual void Change(Event tempo)
        {
            this.Name = tempo.Name;
            this.Time = tempo.Time;
            this.Text = tempo.Text;
            this.repeat = tempo.repeat;
        }
    }
}
