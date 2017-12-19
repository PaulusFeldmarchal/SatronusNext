using SatronusNext.eventType;
using System;


namespace SatronusNext
{   
    [Serializable]
    public class ConverterData
    {
        #region fields

        private bool type;
        private DateTime time;
        private string name;
        private string text;
        private string sound;
        #endregion

        #region prop

        public string Text { get => text; set => text = value; }
        public string Name { get => name; set => name = value; }
        public DateTime Time { get => time; set => time = value; }
        public bool Type { get => type; set => type = value; }
        public string Sound { get => sound; set => sound = value; }

        #endregion

        #region methods

        public ConverterData() { }

        public ConverterData(bool type, DateTime time, string name, string text, string sound)
        {
            this.type = type;
            this.time = time;
            this.name = name;
            this.text = text;
            this.sound = sound;
        }

        public ConverterData(DateTime time, string name, string text)
        {
            this.type = false;
            this.time = time;
            this.name = name;
            this.text = text;
            this.sound = null;
        }

        public static Event ToEvent(ConverterData aim)
        {
            Event result = null;

            if (aim.type)
                result = new AlarmClock(aim.name, aim.time, aim.text, new System.Media.SoundPlayer(aim.sound));
            else
                result = new Note(aim.name, aim.time, aim.text);

            return result;
        }

        public static ConverterData ToConverterData(Event aim)
        {
            ConverterData result = null;

            if (aim is AlarmClock ai)
            {
                result = new ConverterData(true, aim.Time, aim.Name, aim.Text, ai.Music.SoundLocation);
            }
            else
            {
                result = new ConverterData(aim.Time, aim.Name, aim.Text);
            }

            return result;
        }

        #endregion
    }
}