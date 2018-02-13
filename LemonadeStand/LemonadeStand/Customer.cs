using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {
        double costWillingToPay;
        public Customer(Random generator)
        {
            int firstDigit = generator.Next(3, 10);
            int secondDigit = generator.Next(0, 10);
            costWillingToPay = double.Parse("." + firstDigit + secondDigit);
        }
        public void AdjustForWeather(Weather currentWeather)
        {

        }
        public void AdjustForLemoneCost(double askingPrice)
        {

        }
        public double GetCostWillingToPay()
        {
            return costWillingToPay;
        }
    }
}
