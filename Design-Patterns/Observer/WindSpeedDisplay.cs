using System;
using Observer;

public class WindSpeedDisplay : IDisplay
{
    private WeatherData data;
    
    public WindSpeedDisplay(WeatherData input)
    {
        data = input;
        data.observers += Update;
    }
    
    public void Update()
    {
        Console.WriteLine("Wind speed now " + data.windSpeed);
    }
}
