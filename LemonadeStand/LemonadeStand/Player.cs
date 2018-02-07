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
        Inventory LemonadeSupplies;
        UI interactions = new UI();

    }
}
