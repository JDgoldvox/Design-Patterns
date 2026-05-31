

namespace Observer
{
    public class HumidityDisplay : IDisplay
    {
        private WeatherData data;

        public HumidityDisplay(WeatherData input)
        {
            data = input;
            data.observers += Update;
        }
        
        public void Update()
        {
            Console.WriteLine("Humidity now " + data.humidity);
        }
    }
}
