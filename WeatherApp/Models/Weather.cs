namespace WeatherApp.Models;

public class Weather
{
    public string CityUniqueCode { get; set; } = string.Empty;
    public string CityName { get; set; } = string.Empty;
    public string DateAndTime { get; set; } = string.Empty;
    public int TemperatureFahrenheit { get; set; }
}