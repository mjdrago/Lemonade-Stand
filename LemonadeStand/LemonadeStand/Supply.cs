﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Supply
    {
        int quantity;
        decimal price;

        public void UseItem(int neededSupplies)
        {
            quantity -= neededSupplies;
        }
    }
}
