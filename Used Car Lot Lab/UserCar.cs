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
        public UserCar(string _make, string _model, int _year, decimal _price, int _mileage) : base(_make, _model, _year, _price)
        {
            Mileage = _mileage;
        }
        public override string ToString()
        {
            return base.ToString() + String.Format("{0,10}, {1,10}", Mileage, "Used");
        }





    }




}
