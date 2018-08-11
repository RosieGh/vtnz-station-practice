using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTNZ
{
    public class CarInspection
    {
        private string _CarServiceName;
        private decimal _CarServicePrice;
        
        public CarInspection(string carServiceName, decimal carServicePrice)
        {
            this._CarServiceName = carServiceName;
            this._CarServicePrice = carServicePrice;
        }

        public string ServiceName { get => _CarServiceName; set => _CarServiceName = value; }
        public decimal ServicePrice { get => _CarServicePrice; set => _CarServicePrice = value; }

        public string ShowCarInspectionDetail()
        {
            return "Inspection Type " + this._CarServicePrice + " \nPrice $" +
                Convert.ToString(this._CarServicePrice);
        }
    }
}
