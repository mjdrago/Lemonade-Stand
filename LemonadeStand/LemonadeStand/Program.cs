﻿using System;
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
            //Inventory foo = new Inventory();
            //Wallet mfoo = new Wallet();
            //foo.DisplayInventory();
            //Console.WriteLine(mfoo.GetBalance());
            //foo.BuyLemons(3, mfoo);
            //foo.BuySugar(4, mfoo);
            //foo.BuyCups(5, mfoo);
            //foo.BuyIce(6, mfoo);
            //foo.DisplayInventory();
            //Console.WriteLine(mfoo.GetBalance());
            //foo.BuyLemons(3, mfoo);
            //foo.BuySugar(3, mfoo);
            //foo.BuyCups(3, mfoo);
            //foo.BuyIce(3, mfoo);
            //foo.DisplayInventory();
            //Console.WriteLine(mfoo.GetBalance());
            //Console.ReadKey();
            //Random generator = new Random();
            //Human test = new Human();

            //Day crr = new Day(generator);
            //crr.PreSellActions(test);
            //test.DisplayPlayerConditions();
            //Console.ReadKey();
            //UI foo = new UI();
            //int n =foo.GetIntMininumValue("Please enter a number greater than 5", 5);
            //Console.WriteLine("arrrr {0}",n);
            //Console.ReadKey();
            Random genera = new Random();
            Customer foo = new Customer(genera);
            Console.WriteLine(foo.GetCostWillingToPay());
            foo = new Customer(genera);
            Console.WriteLine(foo.GetCostWillingToPay());
            Console.ReadKey();

        }
    }
}
