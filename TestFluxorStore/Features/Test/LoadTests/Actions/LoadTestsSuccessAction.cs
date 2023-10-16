using System.Collections.ObjectModel;


namespace TestFluxorStore.Features.Test.LoadTests.Actions;

public class LoadTestsSuccessAction
{
    public LoadTestsSuccessAction(List<string> tests)
    {
        Tests = tests;
    }

    public List<string> Tests { get; }
}
