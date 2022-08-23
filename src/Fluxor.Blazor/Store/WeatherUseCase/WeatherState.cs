using Shared;

namespace Fluxor.Blazor.Store.WeatherUseCase
{
	[FeatureState]
	public class WeatherState
	{
		public bool IsLoading { get; }

		public DateTime LastUpdated { get;  }
		public IEnumerable<WeatherForecast> Forecasts { get; }

		private WeatherState() { }
		public WeatherState(bool isLoading, IEnumerable<WeatherForecast> forecasts, DateTime lastUpdated)
        {
            IsLoading = isLoading;
            Forecasts = forecasts ?? Array.Empty<WeatherForecast>();
            LastUpdated = lastUpdated;
        }
    }
}
