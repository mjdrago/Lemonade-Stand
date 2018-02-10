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
            BuySupplies(activePlayer);
            SetRecipe();
            SetPrice();
            SellLemonade();
        }

        public void BuySupplies(Player standOwner)
        {
            bool checker = true;
            while (checker == true)
            {
                standOwner.DisplayPlayerConditions();
                string input = standOwner.interactions.GetStringInput("Would you like to buy:\n" +
                                                                      " - Lemons? Please enter '1'.\n" +
                                                                      " - Sugar Cubes? Please enter '2'.\n" +
                                                                      " - Ice Cubes? Please enter '3'.\n" +
                                                                      " - Cups? Please enter '4'.\n" +
                                                                      "To leave the store please enter '5'.");
                int numberNeeded;
                switch (input)
                {
                    case "1":
                        numberNeeded = standOwner.interactions.GetIntInput("How many lemons would you like to buy?");
                        standOwner.lemonadeSupplies.BuyLemons(numberNeeded, standOwner.fund);
                        break;
                    case "2":
                        numberNeeded = standOwner.interactions.GetIntInput("How many sugar cubes would you like to buy?");
                        standOwner.lemonadeSupplies.BuySugar(numberNeeded, standOwner.fund);
                        break;
                    case "3":
                        numberNeeded = standOwner.interactions.GetIntInput("How many ice cubes would you like to buy?");
                        standOwner.lemonadeSupplies.BuyIce(numberNeeded, standOwner.fund);
                        break;
                    case "4":
                        numberNeeded = standOwner.interactions.GetIntInput("How many cups would you like to buy?");
                        standOwner.lemonadeSupplies.BuyCups(numberNeeded, standOwner.fund);
                        break;
                    case "5":
                        checker = false;
                        break;
                    default:
                        Console.WriteLine("This was an invalid option. Please try again.");
                        BuySupplies(standOwner);
                        checker = false;
                        break;
                }
            }
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
