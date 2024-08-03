namespace Gamoya.Weather.WeatherUnlocked.Example {
    internal class Program {
        static async Task Main(string[] args) {
            string appId = Environment.GetEnvironmentVariable("WEATHER_UNLOCKED_APP_ID");
            string appKey = Environment.GetEnvironmentVariable("WEATHER_UNLOCKED_APP_KEY");
            string languageCode = "en";
            bool ssl = false;

            var latitude = 52.520008m;
            var longitude = 13.404954m;

            using (var weatherUnlockedClient = new WeatherUnlockedClient(appId, appKey, languageCode, ssl)) {
                var currentWeather = await weatherUnlockedClient.GetCurrentWeatherAsync(latitude, longitude);
                Console.WriteLine(string.Format("The temperature in Berlin is {0}°C", currentWeather.TemperatureCelsius));

                var weatherForecast = await weatherUnlockedClient.GetForecastWeatherAsync(latitude, longitude);
                foreach (var forecastDay in weatherForecast.Days) {
                    Console.WriteLine(string.Format("The temperature in Berlin on {0} is {1}°C", forecastDay.Date, currentWeather.TemperatureCelsius));
                }
            }
        }
    }
}
