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
            UI round = new UI();
            round.GetStringInput("Please Enter a Word");
            Console.ReadKey();
        }
    }
}
