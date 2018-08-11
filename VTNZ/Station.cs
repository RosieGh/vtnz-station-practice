using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTNZ
{
    public abstract class Station
    {
        
        protected string z_registrationName;
        protected string z_address;
        protected string z_telNumber;
        protected string z_businessTime;

        public string RegistrationName{ get;set;}

        public string Address
        {
            get;
            set;
        }

        public string TelNumber
        {
            get;
            set;
        }

        public string BusinessTime
        {
            get;
            set;
        }


        public abstract string ShowStationDetail();
    }

}
