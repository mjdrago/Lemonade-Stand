using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Wallet
    {
        double balance;

        public Wallet()
        {
            balance = 50;
        }

        public double GetBalance()
        {
            return balance;
        }

        public bool WithdrawMoney(double amountNeeded)
        {
            if (balance >= amountNeeded)
            {
                balance -= amountNeeded;
                return true;
            }
            return false;
        }
    }
}
