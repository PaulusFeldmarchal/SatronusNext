using SatronusNext.eventType;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Threading;
using System.Windows;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Xml.Serialization;
using System.Media;

namespace SatronusNext
{
    public class SerialData : SoundPlayer
    {
        #region fields
        private ObservableCollection<Event> list;
        public ObservableCollection<Event> OurList { get { return list; } set { list = value; } }

        Dispatcher TempDispatcher;
        private static String nameFile = "Data.ev";
        private static String nameVarFile = "Num.nu";
        #endregion

        public SerialData()
        {
            TempDispatcher = Dispatcher.CurrentDispatcher;
        }
        public static int CompMethod(Event temp, Event temp1)
        {
            return temp.Name.CompareTo(temp1.Name);
        }
        public SerialData(ObservableCollection<Event> list)
        {
            this.list = list;
        }
        public void Sort()
        {
           
              TempDispatcher.Invoke(() =>
                {
                    var SortList = new List<Event>(OurList);
                    SortList.Sort();
                    for (int i = 0; i < SortList.Count; i++)
                    {
                       OurList.Move(OurList.IndexOf(SortList[i]), i); 
                    }
                    for (int i = OurList.Count; i > 0; i--)
                    {
                        if (OurList[0].Time.CompareTo(DateTime.Now) < 0)
                        {
                            OurList.Remove(OurList[0]);
                        }
                    }
                });
        }
        public void DeleteEvent(Event temp)
        {
            TempDispatcher.Invoke(() =>
            {
                OurList.Remove(temp);
            });
        }

        public async Task<List<Event>> NearCalls()
        {
            return await Task<List<Event>>.Factory.StartNew(() =>
            {
                List<Event> temp = new List<Event>();
                foreach(Event q in OurList)
                {
                    if (q.Time.CompareTo(DateTime.Now.AddHours(1))<=0)
                    {
                        temp.Add(q);
                    }
                }          
                return temp;
            });
        }
        public void SerializationList()
        {
            if (list == null)
                return;
            if (File.Exists(nameFile) || File.Exists(nameVarFile))
            {
                File.Delete(nameFile);
                File.Delete(nameVarFile);
            }

            try
            {//*/
                ConverterData[] ser = new ConverterData[this.OurList.Count];
                int i = 0;
                foreach (var item in this.OurList)
                {
                    ser[i] = ConverterData.ToConverterData(item);
                    i++;
                }
                using (FileStream fs = new FileStream(nameVarFile, FileMode.OpenOrCreate))
                {
                    XmlSerializer formatter = new XmlSerializer(typeof(int));
                    formatter.Serialize(fs, ser.Length);
                }
                using (FileStream fs = new FileStream(nameFile, FileMode.OpenOrCreate))
                { 
                    XmlSerializer formatter = new XmlSerializer(typeof(ConverterData[]));
                    formatter.Serialize(fs, ser);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex.InnerException));
            }//*/
        }

        public ObservableCollection<Event> DeserializationList()
        {
            if (!File.Exists(nameFile) || !File.Exists(nameFile))
                return null;
            ObservableCollection<Event> result = new ObservableCollection<Event>();
            try
            {//*/
                ConverterData[] loadedList = null;
            using (FileStream fs = new FileStream(nameVarFile, FileMode.OpenOrCreate))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(int));
                int len = (int)xmlSerializer.Deserialize(fs);
                loadedList = new ConverterData[len];
            }
            using (FileStream fs = new FileStream(nameFile, FileMode.OpenOrCreate))
                {
                XmlSerializer formatter = new XmlSerializer(typeof(ConverterData[]));
                    loadedList = (ConverterData[])formatter.Deserialize(fs);
                }
                for (int i = 0; i < loadedList.Length; i++)
                    result.Add(ConverterData.ToEvent(loadedList[i]));
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return null;
            }//*/
            return result;
        }
    }

}
