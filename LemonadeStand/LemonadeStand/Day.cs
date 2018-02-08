using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        Random generator;
        Weather currentWeather;
        int totalNumberOfCustomers;

        public Day(Random generator)
        {
            this.generator = generator;
            currentWeather = new Weather(generator);
            currentWeather.DetermineWeather();
            totalNumberOfCustomers = generator.Next(80, 120);
        }

        public void DaysAction(Player activePlayer)
        {
            BuySupplies();
            SetRecipe();
            SetPrice();
            SellLemonade();
        }

        private void BuySupplies()
        {
            throw new NotImplementedException();
        }

        private void SetRecipe()
        {
            throw new NotImplementedException();
        }

        private void SetPrice()
        {
            throw new NotImplementedException();
        }

        private void SellLemonade()
        {
            throw new NotImplementedException();
        }
    }
}
