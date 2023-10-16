using Fluxor;

using Microsoft.Extensions.Logging;

using TestFluxorStore.Features.Test.LoadTests.Actions;

using IDispatcher = Fluxor.IDispatcher;

namespace TestFluxorStore.Features.Test.LoadTests.Effects;

public class LoadTestsEffect : Effect<LoadTestsAction>
{
    private readonly ILogger<LoadTestsEffect> _logger;

    public LoadTestsEffect(ILogger<LoadTestsEffect> logger)
    {
        _logger = logger;
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
