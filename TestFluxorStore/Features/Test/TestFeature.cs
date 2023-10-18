using System.Collections.ObjectModel;

using Fluxor;

using TestFluxorStore.Core.Features.Test.DTOs;
using TestFluxorStore.State;

namespace TestFluxorStore.Features.Test;

public class InventoryFeature : Feature<TestState>
{
    public override string GetName() => "Test";

    protected override TestState GetInitialState() => new TestState
    {
        IsLoading = false,
        CurrentErrorMessage = string.Empty,

        Tests = new List<string>(),
        Posts = new List<Post>(),
    };
}
