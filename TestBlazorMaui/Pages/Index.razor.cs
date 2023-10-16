using Microsoft.AspNetCore.Components;
using TestFluxorStore.Features.Test.LoadTests.Actions;
using Fluxor;
using TestFluxorStore.State;
using IDispatcher = Fluxor.IDispatcher;

namespace TestBlazorMaui.Pages
{
    public partial class Index
    {
        [Inject]
        private IState<TestState> TestState { get; set; }

        [Inject]
        private IDispatcher Dispatcher { get; set; }
        protected override void OnInitialized()
        {
            base.OnInitialized();
            Dispatcher.Dispatch(new LoadTestsAction());
        }
    }
}