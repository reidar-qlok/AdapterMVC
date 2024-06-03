namespace AdapterMVC.Models
{
    public class WeatherServiceAdapter : IWeatherService
    {
        private readonly LegacyWeatherService _legacyWeatherService;

        public WeatherServiceAdapter(LegacyWeatherService legacyWeatherService)
        {
            _legacyWeatherService = legacyWeatherService;
        }

        public string GetWeather()
        {
            var temp = _legacyWeatherService.GetWeatherData();
            return temp;
        }
    }
}
