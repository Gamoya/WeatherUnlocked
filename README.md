# WeatherUnlocked
A .NET client for Weather Unlocked

## Usage

```C#
string appId = "{your appId}";
string appKey = "{your appKey}";
string languageCode = "en";
bool ssl = false;

decimal latitude = 52.520008m;
decimal longitude = 13.404954m;

using (var weatherUnlockedClient = new Gamoya.Weather.WeatherUnlockedClient(appId, appKey, languageCode, ssl)) {
    var currentWeather = await GetCurrentWeatherAsync(latitude, longitude);
    var forecastWeather = await GetForecastWeatherAsync(latitude, longitude);
}
```
