using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class UI
    {
        public string GetStringInput(string DisplayText)
        {
            Console.WriteLine(DisplayText);
            string input = Console.ReadLine();
            return input;
        }

        public int GetIntInput(string DisplayText)
        {
            string stringInput = GetStringInput(DisplayText);
            int intOutput = 0;
            bool CanConvert = Int32.TryParse(stringInput, out intOutput);
            try
            {
                intOutput = Int32.Parse(stringInput);
            }
            catch (Exception)
            {
                Console.WriteLine("This was not a valid entry. Please try again.");
                intOutput = GetIntInput(DisplayText);
            }
            return intOutput;
        }
    }
}
