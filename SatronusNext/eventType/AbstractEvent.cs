using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatronusNext
{
    abstract class AbstractEvent
    {
            public string Name { get; set; }
            public DateTime Time { get; set; }
            public AbstractEvent() { Time = DateTime.Now; }
            public AbstractEvent(string name, DateTime time)
            {
                Time = time;
                Name = name;
            }
        }
}
