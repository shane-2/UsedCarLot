using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Used_Car_Lot_Lab
{
    internal class UserCar : Car
    {
        public int Mileage{get; set;}
        public UserCar(string _make, string _model, int _year, decimal _price, int Mileage) : base(_make, _model, _year, _price)
        {
        }

    }
}
