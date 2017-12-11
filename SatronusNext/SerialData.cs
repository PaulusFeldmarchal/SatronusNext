using SatronusNext.eventType;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatronusNext
{
    [Serializable]
    class SerialData
    {
        private ObservableCollection<Event> list;

        private static String path = @"./Datas";

        public SerialData(ObservableCollection<Event> list)
        {

        }
    }
}
