using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SatronusNext
{
    class Log
    {
        private static String nameFile = @"Resources/Sesion.log";

        public static void Serialization(Program Program)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            if (File.Exists(nameFile))
                File.Delete(nameFile);
            using (FileStream fs = new FileStream(nameFile, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, Program);
            }
        }
        public static void DeleteSesion()
        {
            if (File.Exists(nameFile))
                File.Delete(nameFile);
        }
        public static Program Deserialization()
        {
            if (!File.Exists(nameFile))
                return null;
            Program tmp = null;
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream(nameFile, FileMode.Open))
            {
                try
                {
                    tmp = (Program)formatter.Deserialize(fs);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return tmp;
        }
        public static bool LogExists()
        {
            return File.Exists(nameFile);
        }
    }
}