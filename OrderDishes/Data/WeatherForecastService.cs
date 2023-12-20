namespace OrderDishes.Data {
    public class WeatherForecastService {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };
        WeatherForecast[] weatherForecasts { get; set; }
        public WeatherForecastService() {
            weatherForecasts = new WeatherForecast[] { };
        }
        public Task<WeatherForecast[]> GetForecastAsync(DateOnly startDate) {
            if (weatherForecasts.Length == 0) {
                weatherForecasts = Enumerable.Range(1, 10).Select(index => new WeatherForecast {
                    Date = startDate.AddDays(index),
                    TemperatureC = Random.Shared.Next(-20, 55),
                    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
                }).ToArray();
            }
            
            return Task.FromResult(weatherForecasts);
        }
    }
}