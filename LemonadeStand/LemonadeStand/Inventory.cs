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
        List<SugarCube> sugarCubes;
        List<IceCube> iceCubes;
        List<Cup> cups;
        public Inventory()
        {
            lemons = new List<Lemon>();
            sugarCubes = new List<SugarCube>();
            iceCubes = new List<IceCube>();
            cups = new List<Cup>();
        }
    }
}
