using Fluxor.Blazor.Store;
using Fluxor.Blazor.Store.WeatherUseCase;
using Microsoft.AspNetCore.Components;

namespace Fluxor.Blazor.Pages
{
	public partial class FetchData
	{
		[Inject] private IState<WeatherState>? WeatherState { get; set; }

		[Inject] private IDispatcher? Dispatcher { get; set; }

		protected override void OnInitialized()
		{
			base.OnInitialized();
			Dispatcher?.Dispatch(new FetchDataAction());
		}
	}
}
