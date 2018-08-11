using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTNZ
{
    public class CarWrap : IServiceType
    {
        private CarInspection _objCarInspection;


        public CarWrap(string name, decimal price)
        {
            _objCarInspection = new CarInspection(name, price);
            //this.ServiceName = name;
            //this.ServicePrice = price;
        }
        public string ServiceName { get => _objCarInspection.ServiceName; set => _objCarInspection.ServiceName = value; }
        public decimal ServicePrice { get => _objCarInspection.ServicePrice; set => _objCarInspection.ServicePrice= value; }
     
        public string ShowServiceDetail()
        {
            return _objCarInspection.ShowCarInspectionDetail();
        }
    }
}
