using Fluxor;

namespace BlazorFluxorSample.Stores.Weather
{
    public static class Reducers
    {
        [ReducerMethod]
        public static WeatherForecastState ReduceSetWeatherForecast(WeatherForecastState state, SetWeatherForecast action) =>
            new (action.Forecasts, null);

        [ReducerMethod]
        public static WeatherForecastState ReduceSetSelectedWeatherForecast(WeatherForecastState state, SetSelectedWeatherForecast action) =>
            new (state.WeatherForecasts, action.index);
    }
}
