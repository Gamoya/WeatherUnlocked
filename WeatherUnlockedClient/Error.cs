using System.Text.Json.Serialization;

namespace Gamoya.Weather.WeatherUnlocked {
    public class Error {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("Message")]
        public string Message { get; set; }

        [JsonPropertyName("Description")]
        public string Description { get; set; }

        [JsonPropertyName("InternalCode")]
        public string InternalCode { get; set; }

        [JsonPropertyName("HelpUrl")]
        public string HelpUrl { get; set; }
    }
}
