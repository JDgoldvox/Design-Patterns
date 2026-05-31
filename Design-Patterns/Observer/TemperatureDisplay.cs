using Observer;
using System;

namespace Observer
{
    public class TemperatureDisplay : IDisplay
    {
        private WeatherData data;
        
        public TemperatureDisplay(WeatherData input)
        {
            data = input;
            data.observers += Update;
        }
        
        public void Update()
        {
            Console.WriteLine("Temperature now " + data.temperature);
        }
    }
}