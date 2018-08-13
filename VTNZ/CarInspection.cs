using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTNZ
{
    public class CarInspection
    {
        private string _carServiceName;
        private decimal _carServicePrice;

        public CarInspection() { }

        public CarInspection(string name, decimal price)
        {
            this._carServiceName = name;
            this._carServicePrice = price;
        }
        public string CarServiceName
        {
            get => _carServiceName;
            set => _carServiceName = value;
        }

        public decimal CarServicePrice
        {
            get => _carServicePrice;
            set => _carServicePrice = value;
        }

        public string ShowCarService()
        {
            return "Inspection Type " + CarServiceName + "\n"
                 + "Price $" + Convert.ToString(CarServicePrice);
        }
    }
}
