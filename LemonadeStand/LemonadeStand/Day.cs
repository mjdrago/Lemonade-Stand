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
            PreSellActions(activePlayer);
            SellLemonade();
        }
        public void PreSellActions(Player activePlayer)
        {
            bool checker = true;
            while (checker == true)
            {
                string input = activePlayer.interactions.GetStringInput("Would you like to go to the store to buy items for your lemonade? Enter '1'.\n" +
                                                                        "Would you like to change the recipe of your Lemonade? Enter '2'. \n" +
                                                                        "If you are ready, enter '3' to start selling lemonade!");
                switch (input)
                {
                    case "1":
                        BuySupplies(activePlayer);
                        break;
                    case "2":
                        SetLemonadeConditions(activePlayer);
                        break;
                    case "3":
                        checker = false;
                        break;
                    default:
                        Console.WriteLine("This was an invalid option. Please try again.");
                        PreSellActions(activePlayer);
                        checker = false;
                        break;
                }
            }
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
                        numberNeeded = standOwner.interactions.GetIntInput("How many cups of sugar would you like to buy?");
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

        public void SetLemonadeConditions(Player standOwner)
        {
            bool checker = true;
            while (checker == true)
            {
                standOwner.DisplayAllLemonadeCondition();
                string input = standOwner.interactions.GetStringInput("Would you like to change:\n" +
                                                                      " - The cost of a cup of lemonade? Please enter '1'.\n" +
                                                                      " - The amount of lemons per pitcher? Please enter '2'.\n" +
                                                                      " - The amount of cups of sugar per pitcher? Please enter '3'.\n" +
                                                                      " - The amount of cubes of ice per cup? Please enter '4'.\n" +
                                                                      "If you like the recipe as is please enter '5'.");
                int amount;
                switch (input)
                {
                    case "1":
                        double price = standOwner.interactions.GetDoubletInput("What price would you like to set it to?");
                        standOwner.SetCostOfLemonade(price);
                        break;
                    case "2":
                        amount = standOwner.interactions.GetIntInput("How many lemons would you like per pitcher?");
                        standOwner.recipe.ChangeLemons(amount);
                        break;
                    case "3":
                        amount = standOwner.interactions.GetIntInput("How many cups of sugar would you like per pitcher?");
                        standOwner.recipe.ChangeSugar(amount);
                        break;
                    case "4":
                        amount = standOwner.interactions.GetIntInput("How many ice cubes would you like per cup?");
                        standOwner.recipe.ChangeIceCubes(amount);
                        break;
                    case "5":
                        checker = false;
                        break;
                    default:
                        Console.WriteLine("This was an invalid option. Please try again.");
                        SetLemonadeConditions(standOwner);
                        checker = false;
                        break;
                }
            }
        }

        private void SellLemonade()
        {
            throw new NotImplementedException();
        }
    }
}
