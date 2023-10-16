using System.Collections.ObjectModel;

namespace TestFluxorStore.State;

public record TestState : RootState
{
    public IEnumerable<string> Tests { get; init; }
}
