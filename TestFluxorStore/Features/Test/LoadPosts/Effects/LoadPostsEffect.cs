using Fluxor;

using Microsoft.Extensions.Logging;

using TestFluxorStore.Core.Features.Test.Interfaces;
using TestFluxorStore.Features.Test.LoadPosts.Actions;

using IDispatcher = Fluxor.IDispatcher;

namespace TestFluxorStore.Features.Test.LoadPosts.Effects;

public class LoadPostsEffect : Effect<LoadPostsAction>
{
    private readonly ILogger<LoadPostsEffect> _logger;
    private readonly IPostsService _postsService;

    public LoadPostsEffect(ILogger<LoadPostsEffect> logger, IPostsService postsService)
    {
        _logger = logger;
        _postsService = postsService;
    }

    public override async Task HandleAsync(LoadPostsAction action, IDispatcher dispatcher)
    {
        try
        {
            var newList = await _postsService.GetPostsAsync();

            dispatcher.Dispatch(new LoadPostsSuccessAction(newList));
        }
        catch (Exception e)
        {
            _logger.LogError($"Error occured, reason: {e.Message}");

            dispatcher.Dispatch(new LoadPostsFailureAction(e.Message));
        }
    }
}
