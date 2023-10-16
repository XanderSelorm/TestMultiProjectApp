using Fluxor;

using TestFluxorStore.Features.Test.LoadTests.Actions;
using TestFluxorStore.State;

namespace TestFluxorStore.Features.Test.LoadTests.Reducers;

public class LoadTestsActionReducer
{
    [ReducerMethod]
    public static TestState ReduceLoadTestsAction(TestState state, LoadTestsAction _) =>
       state with
       {
           IsLoading = true,
       };

    [ReducerMethod]
    public static TestState ReduceLoadTestsSuccessAction(TestState state, LoadTestsSuccessAction action) =>
        state with
        {
            IsLoading = false,
            Tests = action.Tests,
        };

    [ReducerMethod]
    public static TestState ReduceLoadTestsFailureAction(TestState state, LoadTestsFailureAction action) =>
       state with
       {
           IsLoading = false,
           CurrentErrorMessage = action.ErrorMessage,
       };
}
