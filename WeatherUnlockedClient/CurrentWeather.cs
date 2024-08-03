using System.Text.Json.Serialization;

namespace Gamoya.Weather.WeatherUnlocked {
    public class CurrentWeather {
        [JsonPropertyName("lat")]
        public decimal? Latitude { get; set; }

        [JsonPropertyName("lon")]
        public decimal? Longitude { get; set; }

        [JsonPropertyName("alt_m")]
        public decimal? AltitudeMeter { get; set; }

        [JsonPropertyName("alt_ft")]
        public decimal? AltitudeFeet { get; set; }

        [JsonPropertyName("wx_desc")]
        public string WeatherConditionDescription { get; set; }

        [JsonPropertyName("wx_code")]
        public int? WeatherConditionCode { get; set; }

        [JsonPropertyName("wx_icon")]
        public string WeatherConditionIcon { get; set; }

        [JsonPropertyName("temp_c")]
        public decimal? TemperatureCelsius { get; set; }

        [JsonPropertyName("temp_f")]
        public decimal? TemperatureFahrenheit { get; set; }

        [JsonPropertyName("feelslike_c")]
        public decimal? FeltTemperatureCelsius { get; set; }

        [JsonPropertyName("feelslike_f")]
        public decimal? FeltTemperatureFahrenheit { get; set; }

        [JsonPropertyName("humid_pct")]
        public decimal? Humidity { get; set; }

        [JsonPropertyName("windspd_mph")]
        public decimal? WindspeedMph { get; set; }

        [JsonPropertyName("windspd_kmh")]
        public decimal? WindspeedKmh { get; set; }

        [JsonPropertyName("windspd_kts")]
        public decimal? WindspeedKnots { get; set; }

        [JsonPropertyName("windspd_ms")]
        public decimal? WindspeedMs { get; set; }

        [JsonPropertyName("winddir_deg")]
        public decimal? WindDirectionDegrees { get; set; }

        [JsonPropertyName("winddir_compass")]
        public string WindDirectionCompass { get; set; }

        [JsonPropertyName("cloudtotal_pct")]
        public decimal? CloudCover { get; set; }

        [JsonPropertyName("vis_km")]
        public decimal? VisibilityKm { get; set; }

        [JsonPropertyName("vis_mi")]
        public decimal? VisibilityMiles { get; set; }

        [JsonPropertyName("vis_desc")]
        public string VisibilityDescription { get; set; }

        [JsonPropertyName("slp_mb")]
        public decimal? PressureMb { get; set; }

        [JsonPropertyName("slp_in")]
        public decimal? PressureIn { get; set; }

        [JsonPropertyName("dewpoint_c")]
        public decimal? DewpointCelsius { get; set; }

        [JsonPropertyName("dewpoint_f")]
        public decimal? DewpointFahrenheit { get; set; }
    }
}
