using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Gamoya.Weather.WeatherUnlocked {
    public class WeatherUnlockedClient : IDisposable {
        private const string _baseUrl = "http://api.weatherunlocked.com/api/";
        private const string _baseUrlSsl = "https://api.weatherunlocked.com/api/";

        private static readonly JsonSerializerOptions _jsonSerializerOptions = new JsonSerializerOptions() {
            PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower
        };

        private readonly HttpClient _httpClient;
        private readonly bool _disposeHttpClient;

        private readonly string _appId;
        private readonly string _appKey;
        private readonly string _languageCode;

        public WeatherUnlockedClient(string appId, string appKey, string languageCode, bool ssl) {
            _httpClient = CreateHttpClient(ssl);
            _disposeHttpClient = true;
            _appId = appId;
            _appKey = appKey;
            _languageCode = languageCode;
        }

        public WeatherUnlockedClient(string appId, string appKey, string languageCode, HttpClient httpClient) {
            _httpClient = httpClient;
            _disposeHttpClient = false;
            _appId = appId;
            _appKey = appKey;
            _languageCode = languageCode;
        }

        public static HttpClient CreateHttpClient(bool ssl) {
            var httpClient = new HttpClient {
                BaseAddress = new Uri(ssl ? _baseUrlSsl : _baseUrl)
            };

            return httpClient;
        }

        public void Dispose() {
            if (_disposeHttpClient) {
                _httpClient.Dispose();
            }
        }

        private static async Task<T> ResultAsync<T>(HttpResponseMessage response) {
            var content = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode) {
                return JsonSerializer.Deserialize<T>(content, _jsonSerializerOptions);
            } else {
                try {
                    var error = JsonSerializer.Deserialize<Error>(content, _jsonSerializerOptions);
                    throw new WeatherUnlockedException(error.Message);
                } catch {
                    throw new WeatherUnlockedException(content);
                }
            }
        }

        public async Task<CurrentWeather> GetCurrentWeatherAsync(decimal latitude, decimal longitude) {
            using (var message = new HttpRequestMessage(HttpMethod.Get, string.Format("current/{0},{1}?app_id={2}&app_key={3}&lang={4}", latitude.ToString(System.Globalization.NumberFormatInfo.InvariantInfo), longitude.ToString(System.Globalization.NumberFormatInfo.InvariantInfo), _appId, _appKey, _languageCode))) {
                using (var response = await _httpClient.SendAsync(message)) {
                    return await ResultAsync<CurrentWeather>(response);
                }
            }
        }

        public async Task<ForecastWeatherResponse> GetForecastWeatherAsync(decimal latitude, decimal longitude) {
            using (var message = new HttpRequestMessage(HttpMethod.Get, string.Format("forecast/{0},{1}?app_id={2}&app_key={3}&lang={4}", latitude.ToString(System.Globalization.NumberFormatInfo.InvariantInfo), longitude.ToString(System.Globalization.NumberFormatInfo.InvariantInfo), _appId, _appKey, _languageCode))) {
                using (var response = await _httpClient.SendAsync(message)) {
                    return await ResultAsync<ForecastWeatherResponse>(response);
                }
            }
        }
    }
}
