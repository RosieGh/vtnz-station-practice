using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTNZ
{
    public class VTNZ_station: Station
    {
        private List<IServiceItem> _objServiceList;
        private int _totalService;
        private decimal _totalPrice;
        private string _allDetails;
        public VTNZ_station() { }
        public VTNZ_station(string vtnzName, string vtnzAddress, string vtnzTel, string vtnzBHour)
        {
            this.zStationName = vtnzName;
            this.zStationAddress = vtnzAddress;
            this.zStationTelNum = vtnzTel;
            this.zStationOpenHour = vtnzBHour;

            _objServiceList = new List<IServiceItem>();
        }
        public override string ShowStationDetail()
        {
            return zStationName + "\n" + zStationAddress + "\n" + zStationTelNum + "\n" +
                zStationOpenHour;
        }
        
        public List<IServiceItem> ObjServiceList { get => _objServiceList; set => _objServiceList = value; }
        public string GetTotalNUmberService() { return Convert.ToString(_totalService); } //{ get => _totalService; set => _totalService = value; }
        public string GetTotalPrice() { return "$" + Convert.ToString(_totalPrice); }//{get => _totalPrice; set => _totalPrice = value; }

        public string GetAllServiceDetail() { return _allDetails;  }

        //Now you need a function for adding service items into the list
        public void AddSingleServiceIntoList(IServiceItem singleService)
        {
            _objServiceList.Add(singleService);
        }

        //then you have items shown in the listbox then let the user choose them 
        //we need to show the what the user has selected from the servicelist

        public void ShowSelectedService(IServiceItem selectedService)
        {
            _totalPrice += selectedService.ServicePrice;
            _totalService++;

            string ServiceDetailOneAtATime = selectedService.ShowService();
            _allDetails += ServiceDetailOneAtATime;
        }



    }
}
