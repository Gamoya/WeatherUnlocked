using System.Text.Json.Serialization;

namespace Gamoya.Weather.WeatherUnlocked {
    public class ForecastTimeframe {
        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("time")]
        public int Time { get; set; }

        [JsonPropertyName("utcdate")]
        public string DateUtc { get; set; }

        [JsonPropertyName("utctime")]
        public int TimeUtc { get; set; }

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

        [JsonPropertyName("windspd_max_mph")]
        public decimal? WindspeedMaxMph { get; set; }

        [JsonPropertyName("windspd_max_kmh")]
        public decimal? WindspeedMaxKmh { get; set; }

        [JsonPropertyName("windspd_max_kts")]
        public decimal? WindspeedMaxKts { get; set; }

        [JsonPropertyName("windspd_max_ms")]
        public decimal? WindspeedMaxMs { get; set; }

        [JsonPropertyName("windgst_max_mph")]
        public decimal? WindgustMaxMph { get; set; }

        [JsonPropertyName("windgst_max_kmh")]
        public decimal? WindgustMaxKmh { get; set; }

        [JsonPropertyName("windgst_max_kts")]
        public decimal? WindgustMaxKts { get; set; }

        [JsonPropertyName("windgst_max_ms")]
        public decimal? WindgustMaxMs { get; set; }

        [JsonPropertyName("cloud_low_pct")]
        public decimal? CloudLowPercent { get; set; }

        [JsonPropertyName("cloud_mid_pct")]
        public decimal? CloudMidPercent { get; set; }

        [JsonPropertyName("cloud_high_pct")]
        public decimal? CloudHighPercent { get; set; }

        [JsonPropertyName("cloudtotal_pct")]
        public decimal? CloudTotalPercent { get; set; }

        [JsonPropertyName("precip_mm")]
        public decimal? PrecipitationMm { get; set; }

        [JsonPropertyName("precip_in")]
        public decimal? PrecipitationIn { get; set; }

        [JsonPropertyName("rain_mm")]
        public decimal? RainMm { get; set; }

        [JsonPropertyName("rain_in")]
        public decimal? RainIn { get; set; }

        [JsonPropertyName("snow_mm")]
        public decimal? SnowMm { get; set; }

        [JsonPropertyName("snow_in")]
        public decimal? SnowIn { get; set; }

        [JsonPropertyName("snow_accum_cm")]
        public decimal? SnowAccumulatedCm { get; set; }

        [JsonPropertyName("snow_accum_in")]
        public decimal? SnowAccumulatedIn { get; set; }

        [JsonPropertyName("prob_precip_pct")]
        public string ProbabilityPrecipitationPercent { get; set; }

        [JsonPropertyName("humid_pct")]
        public decimal? HumidityPercent { get; set; }

        [JsonPropertyName("dewpoint_c")]
        public decimal? DewpointCelsius { get; set; }

        [JsonPropertyName("dewpoint_f")]
        public decimal? DewpointFahrenheit { get; set; }

        [JsonPropertyName("vis_km")]
        public decimal? VisibilityKm { get; set; }

        [JsonPropertyName("vis_mi")]
        public decimal? VisibilityMi { get; set; }

        [JsonPropertyName("slp_mb")]
        public decimal? PressureMb { get; set; }

        [JsonPropertyName("slp_in")]
        public decimal? PressureIn { get; set; }

        [JsonPropertyName("winddir_deg")]
        public decimal? WindDirectionDegree { get; set; }

        [JsonPropertyName("winddir_compass")]
        public string WindDirectionCompass { get; set; }
    }
}
