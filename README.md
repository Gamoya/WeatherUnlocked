# WeatherUnlocked
An aot compatible .NET client for Weather Unlocked (http://www.weatherunlocked.com/)

[![NuGet](https://img.shields.io/nuget/v/Gamoya.Weather.WeatherUnlocked)](https://www.nuget.org/packages/Gamoya.Weather.WeatherUnlocked)
[![GitHub](https://img.shields.io/github/license/Gamoya/WeatherUnlocked)](https://github.com/Gamoya/WeatherUnlocked/blob/main/LICENSE)

## Prerequisites
Get API-Key from http://www.weatherunlocked.com/

## Usage

```C#
string appId = "{your appId}";
string appKey = "{your appKey}";
string languageCode = "en";
bool ssl = false;

decimal latitude = 52.520008m;
decimal longitude = 13.404954m;

using (var weatherUnlockedClient = new Gamoya.Weather.WeatherUnlocked.WeatherUnlockedClient(appId, appKey, languageCode, ssl)) {
    var currentWeather = await GetCurrentWeatherAsync(latitude, longitude);
    var forecastWeather = await GetForecastWeatherAsync(latitude, longitude);
}
```
