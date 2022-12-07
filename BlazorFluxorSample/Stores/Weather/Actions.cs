using BlazorFluxorSample.Data;

namespace BlazorFluxorSample.Stores.Weather
{
    public record GetWeatherForecast();
    public record SetWeatherForecast(WeatherForecast[] Forecasts);
    public record SetSelectedWeatherForecast(int index);
}
