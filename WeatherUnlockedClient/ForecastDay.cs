using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Gamoya.Weather.WeatherUnlocked {
    public class ForecastDay {
        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("sunrise_time")]
        [JsonConverter(typeof(TimeSpanConverter))]
        public TimeSpan SunriseTime { get; set; }

        [JsonPropertyName("sunset_time")]
        [JsonConverter(typeof(TimeSpanConverter))]
        public TimeSpan SunsetTime { get; set; }

        [JsonPropertyName("moonrise_time")]
        [JsonConverter(typeof(TimeSpanConverter))]
        public TimeSpan MoonriseTime { get; set; }

        [JsonPropertyName("moonset_time")]
        [JsonConverter(typeof(TimeSpanConverter))]
        public TimeSpan MoonsetTime { get; set; }

        [JsonPropertyName("temp_max_c")]
        public decimal? TemperatureMaxCelsius { get; set; }

        [JsonPropertyName("temp_max_f")]
        public decimal? TemperatureMaxFahrenheit { get; set; }

        [JsonPropertyName("temp_min_c")]
        public decimal? TemperatureMinCelsius { get; set; }

        [JsonPropertyName("temp_min_f")]
        public decimal? TemperatureMinFahrenheit { get; set; }

        [JsonPropertyName("precip_total _mm")]
        public decimal? PrecipitationTotalMm { get; set; }

        [JsonPropertyName("percip_total_in")]
        public decimal? PrecipitationTotalIn { get; set; }

        [JsonPropertyName("rain_total_mm")]
        public decimal? RainTotalMm { get; set; }

        [JsonPropertyName("rain_total_in")]
        public decimal? RainTotalIn { get; set; }

        [JsonPropertyName("snow_total_mm")]
        public decimal? SnowTotalMm { get; set; }

        [JsonPropertyName("snow_total_in")]
        public decimal? SnowTotalIn { get; set; }

        [JsonPropertyName("prob_precip_pct")]
        public decimal? ProbabilityPrecipitationPercent { get; set; }

        [JsonPropertyName("humid_max_pct")]
        public decimal? HumidityMaxPercent { get; set; }

        [JsonPropertyName("humid_min_pct")]
        public decimal? HumidityMinPercent { get; set; }

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

        [JsonPropertyName("slp_max_in")]
        public decimal? PressureMaxIn { get; set; }

        [JsonPropertyName("slp_max_mb")]
        public decimal? PressureMaxMb { get; set; }

        [JsonPropertyName("slp_min_in")]
        public decimal? PressureMinIn { get; set; }

        [JsonPropertyName("slp_min_mb")]
        public decimal? PressureMinMb { get; set; }

        [JsonPropertyName("Timeframes")]
        public List<ForecastTimeframe> Timeframes { get; set; }
    }
}
