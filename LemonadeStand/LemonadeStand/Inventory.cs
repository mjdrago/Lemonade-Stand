using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Inventory
    {
        List<Lemon> lemons;
        List<Sugar> sugar;
        List<IceCube> iceCubes;
        List<Cup> cups;
        public Inventory()
        {
            lemons = new List<Lemon>();
            sugar = new List<Sugar>();
            iceCubes = new List<IceCube>();
            cups = new List<Cup>();
        }

        public void DisplayInventory()
        {
            Console.WriteLine("Your current supplies are:");
            Console.WriteLine(" - Lemons: {0}",lemons.Count);
            Console.WriteLine(" - Cups of Sugar: {0}", sugar.Count);
            Console.WriteLine(" - Ice Cubes: {0}", iceCubes.Count);
            Console.WriteLine(" - Cups: {0}", cups.Count);
        }

        public void BuyLemons(int numberNeeded,Wallet money)
        {
            Store grocer = new Store();
            List<Lemon> boughtLemons = grocer.SellLemons(numberNeeded, money);
            lemons.AddRange(boughtLemons);
        }

        public void BuySugar(int numberNeeded, Wallet money)
        {
            Store grocer = new Store();
            List<Sugar> boughtSugar = grocer.SellSugar(numberNeeded, money);
            sugar.AddRange(boughtSugar);
        }

        public void BuyIce(int numberNeeded, Wallet money)
        {
            Store grocer = new Store();
            List<IceCube> boughtIce = grocer.SellIce(numberNeeded, money);
            iceCubes.AddRange(boughtIce);
        }

        public void BuyCups(int numberNeeded, Wallet money)
        {
            Store grocer = new Store();
            List<Cup> boughtCups = grocer.SellCups(numberNeeded, money);
            cups.AddRange(boughtCups);
        }

        public void UseItems(int numberNeeded)
        {

        }
    }
}
