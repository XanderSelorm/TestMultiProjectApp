using Fluxor;

using TestFluxorStore.Features.Test.LoadPosts.Actions;
using TestFluxorStore.State;

namespace TestFluxorStore.Features.Test.LoadPosts.Reducers;

public class LoadPostsActionReducer
{
    [ReducerMethod]
    public static TestState ReduceLoadPostsAction(TestState state, LoadPostsAction _) =>
       state with
       {
           IsLoading = true,
       };

    [ReducerMethod]
    public static TestState ReduceLoadPostsSuccessAction(TestState state, LoadPostsSuccessAction action) =>
        state with
        {
            IsLoading = false,
            Posts = action.Posts,
        };

    [ReducerMethod]
    public static TestState ReduceLoadPostsFailureAction(TestState state, LoadPostsFailureAction action) =>
       state with
       {
           IsLoading = false,
           CurrentErrorMessage = action.ErrorMessage,
       };
}
