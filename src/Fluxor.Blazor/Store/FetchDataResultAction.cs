using Shared;

namespace Fluxor.Blazor.Store
{
	public class FetchDataResultAction
	{
		public IEnumerable<WeatherForecast> Forecasts { get; }
        public DateTime DateUpdated { get; }

        public FetchDataResultAction(IEnumerable<WeatherForecast> forecasts, DateTime dateUpdated)
        {
            Forecasts = forecasts;
            DateUpdated = dateUpdated;
        }
    }
}
