using Shared;

namespace Fluxor.Blazor.Store.WeatherUseCase
{
	public class Effects
	{
		private readonly HttpClient _http;

		public Effects(HttpClient http)
		{
			_http = http;
		}

		[EffectMethod]
		public async Task HandleAsync(FetchDataAction action, IDispatcher dispatcher)
		{
			var forecasts = await _http.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast");
			dispatcher.Dispatch(new FetchDataResultAction(forecasts, DateTime.Now));
		}
	}
}
