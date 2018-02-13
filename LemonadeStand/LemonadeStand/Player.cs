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
        public int cupsOfLemonade;

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
        public bool MakeCupsOfLemonade()
        {
            bool madeCups;
            if (lemonadeSupplies.GetSugarAmount() >= recipe.GetSugarInRecipe()
                && lemonadeSupplies.GetLemonAmount() >= recipe.GetLemonsInRecipe())
            {
                cupsOfLemonade = 12;
                lemonadeSupplies.UseLemons(recipe.GetLemonsInRecipe());
                lemonadeSupplies.UseSugar(recipe.GetSugarInRecipe());
                madeCups = true;
            }
            else
            {
                madeCups = false;
            }
            
            return madeCups;
        }
        public bool PourLemonade()
        {
            bool pouredLemonade;
            if (lemonadeSupplies.GetIceCubeAmount() >= recipe.GetIceInRecipe()
                && lemonadeSupplies.GetCupAmount() >= 1)
            {
                cupsOfLemonade -= 1;
                lemonadeSupplies.UseIceCube(recipe.GetIceInRecipe());
                lemonadeSupplies.UseCup(1);
                pouredLemonade = true;
            }
            else
            {
                pouredLemonade = false;
            }
            return pouredLemonade;
        }
        public bool SellLemonade(Customer buyer)
        {
            if (cupsOfLemonade == 0)
            {
                if (MakeCupsOfLemonade() == true)
                {
                    if (buyer.BuyLemonade(lemonadeCost) == true)
                    {
                        if (PourLemonade() == true)
                        {
                            fund.DepositMoney(lemonadeCost);
                            return true;
                        }
                        else
                        {
                            Console.WriteLine("No more lemonade to sell.");
                            return false;
                        }
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    Console.WriteLine("No more lemonade to sell.");
                    return false;
                }
            }
            else
            {
                if (buyer.BuyLemonade(lemonadeCost) == true)
                {
                    if (PourLemonade() == true)
                    {
                        fund.DepositMoney(lemonadeCost);
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("No more lemonade to sell.");
                        return false;
                    }
                }
                else
                {
                    return true;
                }
            }
        }
    }
}
