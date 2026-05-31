using Observer;

public class WeatherData
{
    public Action observers;
    public int temperature;
    public int windSpeed;
    public int humidity;

    public WeatherData()
    {
        temperature = 12;
        windSpeed = 20;
        humidity = 80;
    }

    public void UpdateNumbers()
    {
        observers.Invoke();
    }
}