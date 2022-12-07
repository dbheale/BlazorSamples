using BlazorFluxorSample.Data;
using Fluxor;

namespace BlazorFluxorSample.Stores.Weather
{
    [FeatureState]
    public class WeatherForecastState
    {
        public WeatherForecast[]? WeatherForecasts { get; set; }
        public int? DefaultIndex { get; set; }

        private WeatherForecastState() { } // Required for creating initial state

        public WeatherForecastState(WeatherForecast[]? weatherForecasts, int? defaultIndex)
        {
            WeatherForecasts = weatherForecasts;
            DefaultIndex = defaultIndex;
        }
    }
}
