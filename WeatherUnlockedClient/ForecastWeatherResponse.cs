using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Gamoya.Weather.WeatherUnlocked {
    public class ForecastWeatherResponse {
        [JsonPropertyName("Days")]
        public List<ForecastDay> Days { get; set; }
    }
}
