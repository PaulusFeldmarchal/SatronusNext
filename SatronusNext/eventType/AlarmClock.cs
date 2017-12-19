using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Drawing;
using System.Collections.ObjectModel;

namespace SatronusNext.eventType
{
    public class AlarmClock : Event 
    {
        SoundPlayer sp;
        public SoundPlayer Music {
            get {
                return sp;
            }
            set
            {
                sp = value;
                if(value == null)
                {
                    //exeption
                }
            }
        }
        public AlarmClock(string changedName) : base() { sp = new SoundPlayer(); PathPicture = "Resources/tasks.png";
        }
        public AlarmClock(string name, DateTime time, string text ,SoundPlayer sound) : base(name,text,  time) { sp = sound;
            PathPicture = "Resources/1.png";
        }
    }
}
