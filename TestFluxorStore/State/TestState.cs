using System.Collections.ObjectModel;

using TestFluxorStore.Core.Features.Test.DTOs;

namespace TestFluxorStore.State;

public record TestState : RootState
{
    public IEnumerable<string> Tests { get; init; }
    public IEnumerable<Post> Posts { get; init; }

}
