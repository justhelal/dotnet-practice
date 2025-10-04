using Microsoft.AspNetCore.Mvc;
using WeatherApp.Models;

namespace WeatherApp.Controllers;

public class WeatherController: Controller
{

    private List<Weather> _weathers = new List<Weather>()
    {
        new Weather(){ CityUniqueCode = "LDN", CityName = "London", DateAndTime = "2030-01-01 8:00",  TemperatureFahrenheit = 33},
        new Weather(){ CityUniqueCode = "NYC", CityName = "London", DateAndTime = "2030-01-01 3:00",  TemperatureFahrenheit = 60 },
        new Weather(){ CityUniqueCode = "PAR", CityName = "Paris", DateAndTime = "2030-01-01 9:00",  TemperatureFahrenheit = 82}
    };
    
    [Route("/weather")]
    [Route("/")]
    public IActionResult All()
    {
        return View(_weathers);
    }

    [Route("/weather/{id}")]
    public IActionResult One(string id)
    {
        var weather = _weathers.FirstOrDefault(i => i.CityUniqueCode == id);
        return View(weather);
    }
}