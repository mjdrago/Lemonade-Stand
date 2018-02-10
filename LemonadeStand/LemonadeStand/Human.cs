using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Human:Player
    {
        public Human()
        {
            interactions = new UI();
            name = interactions.GetStringInput("Please enter your name:");
            lemonadeSupplies = new Inventory();
            fund = new Wallet();
            recipe = new LemonadeRecipe();
            lemonadeCost = .25;
        }
    }
}
