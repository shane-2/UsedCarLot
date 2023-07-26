using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Used_Car_Lot_Lab
{
    internal class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        


        //constructors
        public Car (string _make, string _model, int _year, decimal _price)
        {
            Make = _make;
            Model = _model;
            Year = _year;
            Price = _price;
        }

        //methods
        public string ShowDetails()
        {
            return String.Format("{0,-11} {1,-11} {2,-4} {3,12:c}", Make, Model, Year, Price);
        }
        public override string ToString()
        {
            return String.Format("{0,-11} {1,-11} {2,-4} {3,12:c}", Make, Model, Year, Price);
        }


    }

}
