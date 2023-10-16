namespace TestFluxorStore.State;

public record RootState
{
    /// <summary>
    /// Gets a value indicating whether flag to set loading.
    /// </summary>
    public bool IsLoading { get; init; }

    /// <summary>
    /// Gets current Error Message.
    /// </summary>
    public string CurrentErrorMessage { get; init; }

    /// <summary>
    /// Gets a value indicating whether flag to check current errors.
    /// </summary>
    public bool HasCurrentErrors => !string.IsNullOrWhiteSpace(CurrentErrorMessage);

}
