using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class LemonadeRecipe
    {
        int lemons;
        int sugar;
        int iceCubes;
        public LemonadeRecipe()
        {
            lemons = 4;
            sugar = 4;
            iceCubes = 4;
        }

        public void ChangeLemons(int itemsNeeded)
        {
            lemons = itemsNeeded;
        }
        public void ChangeSugar(int itemsNeeded)
        {
            sugar = itemsNeeded;
        }
        public void ChangeIceCubes(int itemsNeeded)
        {
            iceCubes = itemsNeeded;
        }
        public void DisplayRecipe()
        {
            Console.WriteLine("The Lemonade you're selling contains:");
            Console.WriteLine(" - {0} lemons per pitcher.", lemons);
            Console.WriteLine(" - {0} cups of sugar per pitcher.", sugar);
            Console.WriteLine(" - {0} ice cubes per cup served.", iceCubes);
        }

    }
}
