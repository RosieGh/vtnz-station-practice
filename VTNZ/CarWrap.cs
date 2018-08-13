using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTNZ
{ 
    public class CarWrap: IServiceItem
    {
        private CarInspection _objCar;

        public CarWrap() { }
        public CarWrap(string name, decimal price)
        {
            _objCar = new CarInspection(name, price);
        }
        public string ServiceName
        {
            get => _objCar.CarServiceName;
            set => _objCar.CarServiceName = value;
 
        }

        public decimal ServicePrice
        {
            get => _objCar.CarServicePrice;
            set => _objCar.CarServicePrice = value;
        }


        public string ShowService()
        {
           return _objCar.ShowCarService();
        }
    }
}
