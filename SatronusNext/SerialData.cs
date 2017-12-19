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

namespace SatronusNext
{
    [Serializable]
    public class SerialData
    {
 

        #region fields
        private ObservableCollection<Event> list;
        public ObservableCollection<Event> OurList { get { return list; } set { list = value; } }
        public int HashSum { private set; get; }
        public object Messa { get; private set; }

        Dispatcher TempDispatcher;

        private static String path = @"./Datas";
        private static String nameFile = "Data.ev";
        private static String nameCopy = "Copy.ev";
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
            this.HashSum = 0;
            this.list = list;
            CalcHash();
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
        private void CalcHash()
        {
            foreach (Event obj in list)
            {
                HashSum += obj.Hash();
            }
        }
        public void SerializationList()
        {
            if (list == null)
                return;
            if (File.Exists(nameFile))
                File.Delete(nameFile);
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                using (FileStream fs = new FileStream(path + nameFile, FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void CreateCopy()
        {
            if (list == null)
                return;
            if (File.Exists(nameCopy))
                File.Delete(nameCopy);
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                using (FileStream fs = new FileStream(path + nameCopy, FileMode.Open))
                {
                    formatter.Serialize(fs, this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public ObservableCollection<Event> DeserializationList()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            SerialData loadedList = null;
            using (FileStream fs = new FileStream(path + nameFile, FileMode.Open))
            {
                loadedList = (SerialData)formatter.Deserialize(fs);
            }
            if (loadedList == null)
            {
                using (FileStream fs = new FileStream(path + nameCopy, FileMode.Open))
                {
                    loadedList = (SerialData)formatter.Deserialize(fs);
                }
            }
            return loadedList.list;
        }
    }

}
