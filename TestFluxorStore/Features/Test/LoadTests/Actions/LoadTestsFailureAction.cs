using TestFluxorStore.Features.Shared.Actions;

namespace TestFluxorStore.Features.Test.LoadTests.Actions;

public class LoadTestsFailureAction : FailureAction
{
    public LoadTestsFailureAction(string errorMessage) : base(errorMessage) { }
}
