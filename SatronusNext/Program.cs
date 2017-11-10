using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SatronusNext.eventType;

namespace SatronusNext
{
    public class Program
    {
        /*
         * User information, need to login and to synchronize with server
         */
        public String EMailString { get; set; }
        public String PasswordString { get; set; }
        public String NameString { get; set; }
        public String SurnameString { get; set; }

        /*
         * Information about new user, need to register
         */
        public String RegistEMailString { get; set; }
        public String RegistPasswordString { get; set; }
        public String RegistNameString { get; set; }
        public String RegistSurnameString { get; set; }

    }

}
