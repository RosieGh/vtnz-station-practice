using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTNZ
{
    public class vtnz : Station
    {
        private List<IServiceType> _serviceList;
        private decimal _totalPrice;
        private int _totalNumber;
        private string _allDetails;
        public vtnz(string Name, string Address, string Telnum, string B_Hours)
        {
            this.z_address = Name;
            this.z_address = Address;
            this.z_telNumber = Telnum;
            this.z_businessTime = B_Hours;

            _serviceList = new List<IServiceType>();
        }

        public List<IServiceType> ServiceList { get => _serviceList; set => _serviceList = value; }

        public override string ShowStationDetail()
        {
            return z_registrationName + "\n" +
                   z_address + "\n" +
                   z_telNumber + "\n" +
                   z_businessTime;
        }


        public  void AddService(IServiceType singleService)
        {
            _serviceList.Add(singleService);
        }


        public string ShowAllDetail()
        {
            return _allDetails;
        }
    
        public string GetTotalPrice()
        {
            return "$"+Convert.ToString(_totalPrice);
        }

        public string GetTotalNumber()
        {
            return Convert.ToString(_totalNumber);
        }

        public void Request(IServiceType selectedService) //selctedService is a representing unified carwrap/truckwrap obj which user has selected from the obj singleservice list aka serviceList
                                                          //you will get the selectedService(singleservice) from the list box in the form class
        {
            _totalPrice += selectedService.ServicePrice;
            _totalNumber++;
            string currentCarServiceDetail = selectedService.ShowServiceDetail();
            _allDetails += currentCarServiceDetail;

           /* "Inspection Type " + this._CarService + " \nPrice $" +
                Convert.ToString(this._CarServicePrice);*/
        }
    }
}
