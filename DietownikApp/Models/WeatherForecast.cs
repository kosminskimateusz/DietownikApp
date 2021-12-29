using System.Text.Json.Serialization;

namespace DietownikApp.Models
{
    public class WeatherForecasts
        {
            [JsonPropertyName("data")]
            public WeatherForecast[] weathers { get; set; }
        }

    public class WeatherForecast
        {
            public DateTime Date { get; set; }
            public int TemperatureC { get; set; }
            public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
            public string Summary { get; set; }
        }
}

