using TestFluxorStore.Features.Shared.Actions;

namespace TestFluxorStore.Features.Test.LoadPosts.Actions;

public class LoadPostsFailureAction : FailureAction
{
    public LoadPostsFailureAction(string errorMessage) : base(errorMessage) { }
}
