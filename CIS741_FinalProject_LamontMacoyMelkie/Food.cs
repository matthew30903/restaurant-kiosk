using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS741_FinalProject_LamontMacoyMelkie
{
    class Food
    {
        // Fields
        private string _name;
        private decimal _price;
        private int _count;

        public static List<Food> orderList = new List<Food>();

        // Constructor
        public Food(string name, decimal price)
        {
            this._name = name;
            this._price = price;
            this._count = 0;
            orderList.Add(this);
        }

        // Name Property
        public string Name
        {
            get { return _name; }
        }
        // Price Property
        public decimal Price
        {
            get { return _price; }
        }
        // Count Property
        public int Count
        {
            get { return _count; }
            set { _count = value; }
        }
        // Total Price Property
        public decimal TotalPrice
        {
            get { return _price * _count; }
        }
        // ToString override method
        public override string ToString()
        {
            return String.Format("{0,-35}| {1,-6}| {2,8:C}", Name, _count.ToString(), TotalPrice);
        }
    }
}
