using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Weather
    {
        int temperature;
        Random generator;
        public Weather(Random generator)
        {
            this.generator = generator;
        }
        public void DetermineWeather()
        {
            GenerateTemperature();
        }
        private void GenerateTemperature()
        {
            temperature = generator.Next(55, 96);
        }
        
        public int GetWeather()
        {
            return temperature;
        }
    }
}
