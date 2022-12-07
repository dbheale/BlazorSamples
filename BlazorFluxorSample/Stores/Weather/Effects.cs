using BlazorFluxorSample.Data;
using Fluxor;

namespace BlazorFluxorSample.Stores.Weather
{
    public class GetWeatherForecastEffect : Effect<GetWeatherForecast>
    {
        private readonly WeatherForecastService _weatherForecastService;

        public GetWeatherForecastEffect(WeatherForecastService weatherForecastService)
        {
            _weatherForecastService = weatherForecastService;
        }

        public override async Task HandleAsync(GetWeatherForecast action, IDispatcher dispatcher)
        {
            var forecasts = await _weatherForecastService.GetForecastAsync(DateTime.Now);
            dispatcher.Dispatch(new SetWeatherForecast(forecasts));
        }
    }
}
