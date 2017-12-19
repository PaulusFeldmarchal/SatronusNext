using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SatronusNext.eventType;

namespace SatronusNext
{
    [Serializable]
    public class Program
    {
        /*
         * User information
         */
        public String EMailString { get; set; }
        public String PasswordString { get; set; }
        public String NameString { get; set; }
        public String SurnameString { get; set; }

        public String ImageSource { get; set; }

        public bool tryToRegist()
        {
            return true;
        }

        public bool tryToSignIn()
        {
            return true;
        }


    }

}
