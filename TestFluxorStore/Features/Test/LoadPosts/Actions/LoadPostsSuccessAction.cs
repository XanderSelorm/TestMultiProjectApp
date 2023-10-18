using System.Collections.ObjectModel;

using TestFluxorStore.Core.Features.Test.DTOs;

namespace TestFluxorStore.Features.Test.LoadPosts.Actions;

public class LoadPostsSuccessAction
{
    public LoadPostsSuccessAction(IEnumerable<Post> posts)
    {
        Posts = posts;
    }

    public IEnumerable<Post> Posts { get; }
}
