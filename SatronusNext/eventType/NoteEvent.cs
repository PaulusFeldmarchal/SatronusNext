using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SatronusNext.eventType
{
    [Serializable]
    public class Note : Event
    {
        public Note() : base() {
            PathPicture = "Resources/tasks.png";
        }
        public Note(string name, DateTime time, string text) : base(name,text,time) { PathPicture = "Resources/tasks.png"; }
    }
}
