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
            name = interactions.GetStringInput("Please enter your name:");
            money = 25;
        }
    }
}
