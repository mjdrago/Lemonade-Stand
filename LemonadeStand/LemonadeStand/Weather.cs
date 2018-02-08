using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        int temperature;
        int conditionReference;
        string conditionText;
        Random generator;
        public Weather(Random generator)
        {
            this.generator = generator;
        }
        public void DetermineWeather()
        {
            GenerateTemperature();
            GenerateConditionReference();
            GetConditionText();
        }
        private void GenerateTemperature()
        {

        }
        private void GenerateConditionReference()
        {

        }

        private void GetConditionText()
        {

        }
    }
}
