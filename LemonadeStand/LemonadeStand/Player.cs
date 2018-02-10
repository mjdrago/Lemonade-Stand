using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public abstract class Player
    {
        public string name;
        public Inventory lemonadeSupplies;
        public UI interactions;
        public Wallet fund;
        public LemonadeRecipe recipe;
        public double lemonadeCost;

        public void DisplayPlayerConditions()
        {
            lemonadeSupplies.DisplayInventory();
            fund.DisplayBalance();
        }

        public void DisplayCostOfLemonade()
        {
            Console.WriteLine("The cost of a cup of lemonade is set to {0}.",lemonadeCost);
        }
        public void DisplayAllLemonadeCondition()
        {
            DisplayCostOfLemonade();
            recipe.DisplayRecipe();
        }
        public double GetCostOfLemonade()
        {
            return lemonadeCost;
        }
        public void SetCostOfLemonade(double desiredCost)
        {
            lemonadeCost = desiredCost;
        }

    }
}
