using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Gamoya.Weather.WeatherUnlocked {

    public class TimeSpanConverter : JsonConverter<TimeSpan> {
        public override TimeSpan Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) {
            if (reader.TokenType == JsonTokenType.String) {
                var timeString = reader.GetString();
                if (TimeSpan.TryParseExact(timeString, "hh\\:mm", System.Globalization.DateTimeFormatInfo.InvariantInfo, System.Globalization.TimeSpanStyles.None, out TimeSpan timeValue)) {
                    return timeValue;
                }
            }

            return default;
        }

        public override void Write(Utf8JsonWriter writer, TimeSpan value, JsonSerializerOptions options) {
            writer.WriteStringValue(value.ToString("hh\\:mm", System.Globalization.DateTimeFormatInfo.InvariantInfo));
        }
    }
}
