using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        public List<Lemon> SellLemons(int lemonsNeeded, Wallet money)
        {
            List<Lemon> lemons = new List<Lemon>();

            for (int i = 0; i < lemonsNeeded; i++)
            {
                Lemon newLemon = new Lemon();
                if (money.WithdrawMoney(newLemon.GetPrice()))
                {
                    lemons.Add(newLemon);
                }
                else
                {
                    Console.WriteLine("You were only able to buy {0} lemons with your available funds.",i);
                    break;
                }
            }
            return lemons;
        }
        public List<SugarCube> SellSugar(int sugarNeeded, Wallet money)
        {
            List<SugarCube> sugar = new List<SugarCube>();

            for (int i = 0; i < sugarNeeded; i++)
            {
                SugarCube newSugar = new SugarCube();
                if (money.WithdrawMoney(newSugar.GetPrice()))
                {
                    sugar.Add(newSugar);
                }
                else
                {
                    Console.WriteLine("You were only able to buy {0} sugar cubes with your available funds.", i);
                    break;
                }
            }
            return sugar;
        }
        public List<IceCube> SellIce(int iceNeeded, Wallet money)
        {
            List<IceCube> ice = new List<IceCube>();

            for (int i = 0; i < iceNeeded; i++)
            {
                IceCube newIce = new IceCube();
                if (money.WithdrawMoney(newIce.GetPrice()))
                {
                    ice.Add(newIce);
                }
                else
                {
                    Console.WriteLine("You were only able to buy {0} ice cubes with your available funds.", i);
                    break;
                }
            }
            return ice;
        }
        public List<Cup> SellCups(int cupsNeeded, Wallet money)
        {
            List<Cup> cups = new List<Cup>();

            for (int i = 0; i < cupsNeeded; i++)
            {
                Cup newCup = new Cup();
                if (money.WithdrawMoney(newCup.GetPrice()))
                {
                    cups.Add(newCup);
                }
                else
                {
                    Console.WriteLine("You were only able to buy {0} cups with your available funds.", i);
                    break;
                }
            }
            return cups;
        }
    }
}
