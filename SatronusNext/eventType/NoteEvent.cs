using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatronusNext.eventType
{
    class NoteEvent : AbstractEvent
    {
        public NoteEvent() : base() {}
        public NoteEvent(string name, DateTime time) : base(name,  time) { }

    }
}
