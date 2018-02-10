using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {
            //Game round = new Game();
            //round.GetTotalDays();
            //Console.ReadKey();
            Inventory foo = new Inventory();
            Wallet mfoo = new Wallet();
            foo.DisplayInventory();
            foo.BuyLemons(3, mfoo);
            foo.BuySugar(4, mfoo);
            foo.BuyCups(5, mfoo);
            foo.BuyIce(6, mfoo);
            foo.DisplayInventory();
            foo.BuyLemons(3, mfoo);
            foo.BuySugar(3, mfoo);
            foo.BuyCups(3, mfoo);
            foo.BuyIce(3, mfoo);
            foo.DisplayInventory();
            Console.ReadKey();
            
        }
    }
}
