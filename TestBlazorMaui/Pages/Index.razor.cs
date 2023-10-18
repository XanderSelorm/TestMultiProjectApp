using Microsoft.AspNetCore.Components;
using TestFluxorStore.Features.Test.LoadTests.Actions;
using Fluxor;
using TestFluxorStore.State;
using IDispatcher = Fluxor.IDispatcher;
using TestFluxorStore.Features.Test.LoadPosts.Actions;

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
            Dispatcher.Dispatch(new LoadPostsAction());
        }
    }
}