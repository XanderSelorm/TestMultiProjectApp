using Fluxor;

using TestFluxorStore.Features.Test.LoadingStatus.Action;
using TestFluxorStore.State;

namespace TestFluxorStore.Features.Test.LoadingStatus.Reducer;

public class SetLoadingStatusReducer
{
    [ReducerMethod]
    public static TestState ReduceSetLoadingStatus(TestState state, SetLoadingStatusAction action)
    {
        return state with
        {
            IsLoading = action.IsLoading,
        };
    }
}
