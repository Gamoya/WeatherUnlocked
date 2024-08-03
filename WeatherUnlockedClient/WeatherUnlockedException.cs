using System;
using System.Runtime.Serialization;

namespace Gamoya.Weather.WeatherUnlocked {
    public class WeatherUnlockedException : Exception {
        public WeatherUnlockedException() : base() { }
        public WeatherUnlockedException(string message) : base(message) { }
        protected WeatherUnlockedException(SerializationInfo info, StreamingContext context) : base(info, context) { }
        public WeatherUnlockedException(string message, Exception innerException) : base(message, innerException) { }
    }
}
