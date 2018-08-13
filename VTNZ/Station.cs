using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTNZ
{
    public abstract class Station
    {
        protected string zStationName;
        protected string zStationAddress;
        protected string zStationTelNum;
        protected string zStationOpenHour;

        public string StationName
        {
            get => zStationName;
            set => zStationName = value;
        }

        public string StaionAddress
        {
            get; set;
        }

        public string StationOpenHour
        {
            get; set;
        }

        public string StationTelNum
        {
            get; set;
        }

        public abstract string ShowStationDetail();
    
    }
}
