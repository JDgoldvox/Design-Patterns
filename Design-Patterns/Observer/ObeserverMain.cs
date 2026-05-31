
using Observer;

public class ObserverMain : IPatternMain
{
	private WeatherData data;
	private TemperatureDisplay temperatureDisplay;
	private WindSpeedDisplay windSpeedDisplay;
	private HumidityDisplay humidityDisplay;
	
	public void Run()
	{
		data = new WeatherData();
		temperatureDisplay = new TemperatureDisplay(data);
		windSpeedDisplay = new WindSpeedDisplay(data);
		humidityDisplay = new HumidityDisplay(data);
		
		data.UpdateNumbers();
		
		data.temperature = 1000;
		data.windSpeed = 1234;
		data.humidity = 9000;
		
		data.UpdateNumbers();
	}
	
	
}
