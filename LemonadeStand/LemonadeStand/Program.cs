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
            Cup foo = new Cup();
            Console.WriteLine(foo.GetName());
            Console.WriteLine(foo.GetPrice());
            Console.ReadKey();
        }
    }
}
