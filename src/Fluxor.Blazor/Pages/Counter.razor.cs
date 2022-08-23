using Fluxor.Blazor.Store;
using Fluxor.Blazor.Store.CounterUseCase;
using Microsoft.AspNetCore.Components;

namespace Fluxor.Blazor.Pages
{
	public partial class Counter
	{
		[Inject]
		private IState<CounterState> CounterState { get; set; }

		[Inject]
		public IDispatcher Dispatcher { get; set; }

		private void IncrementCount()
		{
			var action = new IncrementCounterAction();
			Dispatcher.Dispatch(action);
		}
	}
}
