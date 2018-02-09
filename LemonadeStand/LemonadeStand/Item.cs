using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public abstract class Item
    {
        protected string name;
        protected double price;

        public string GetName()
        {
            return name;
        }
        public double GetPrice()
        {
            return price;
        }
    }
}
