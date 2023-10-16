namespace TestFluxorStore.Features.Test.LoadingStatus.Action;
public class SetLoadingStatusAction
{
    public SetLoadingStatusAction(bool isLoading)
    {
        IsLoading = isLoading;
    }

    public bool IsLoading { get; set; }
}
