using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Customer
    {
        double costWillingToPay;
        public Customer(Random generator)
        {
            int firstDigit = generator.Next(3, 10);
            int secondDigit = generator.Next(0, 10);
            costWillingToPay = double.Parse("." + firstDigit + secondDigit);
        }
        public double AdjustForWeather(Weather currentWeather)
        {
            double weatherAdjustment = ((currentWeather.GetWeather() - 70) * 0.02);
            return weatherAdjustment;
        }
        public double AdjustForLemonadeCost(double askingPrice)
        {
            double lemonadeCostAdjustment = ((askingPrice - .50) * 0.01)/2;
            return lemonadeCostAdjustment;
        }

        public void GetFinalCostWillingToPay(Weather currentWeather, double askingPrice)
        {
            double weatherAdjustment = AdjustForWeather(currentWeather);
            double priceAdjustment = AdjustForLemonadeCost(askingPrice);
            double potentialPriceCost = costWillingToPay + weatherAdjustment - priceAdjustment;
            costWillingToPay = Math.Max(0, potentialPriceCost);
        }
        public bool BuyLemonade(double askingPrice)
        {
            if (askingPrice <= costWillingToPay)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public double GetCostWillingToPay()
        {
            return costWillingToPay;
        }
    }
}
