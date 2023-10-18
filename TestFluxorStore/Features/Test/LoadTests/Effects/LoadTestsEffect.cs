using Fluxor;

using Microsoft.Extensions.Logging;

using TestFluxorStore.Core.Features.Test.Interfaces;
using TestFluxorStore.Features.Test.LoadTests.Actions;

using IDispatcher = Fluxor.IDispatcher;

namespace TestFluxorStore.Features.Test.LoadTests.Effects;

public class LoadTestsEffect : Effect<LoadTestsAction>
{
    private readonly ILogger<LoadTestsEffect> _logger;
    private readonly IPostsService _postsService;

    public LoadTestsEffect(ILogger<LoadTestsEffect> logger, IPostsService postsService)
    {
        _logger = logger;
        _postsService = postsService;
    }

    public override async Task HandleAsync(LoadTestsAction action, IDispatcher dispatcher)
    {
        try
        {
            var newList = new List<string>() { 
                "test 1",
                "test 2",
                "test 3"
            };

            dispatcher.Dispatch(new LoadTestsSuccessAction(newList));
        }
        catch (Exception e)
        {
            _logger.LogError($"Error occured, reason: {e.Message}");

            dispatcher.Dispatch(new LoadTestsFailureAction(e.Message));
        }
    }
}
