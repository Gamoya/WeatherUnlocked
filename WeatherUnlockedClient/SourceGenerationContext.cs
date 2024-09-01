using System.Text.Json.Serialization;

#if NET8_0_OR_GREATER

namespace Gamoya.Weather.WeatherUnlocked {
    [JsonSourceGenerationOptions()]
    [JsonSerializable(typeof(CurrentWeather))]
    [JsonSerializable(typeof(ForecastWeatherResponse))]
    [JsonSerializable(typeof(Error))]
    internal partial class SourceGenerationContext : JsonSerializerContext {
    }
}

#endif
