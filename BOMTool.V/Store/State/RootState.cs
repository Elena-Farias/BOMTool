namespace BOMTool.V.Store.State
{
    public class RootState
    {
        public RootState(bool isLoading, string? currentErrorMessage) =>
            (IsLoading, CurrentErrorMessage) = (isLoading, currentErrorMessage);

        public bool IsLoading { get;  }
        public string? CurrentErrorMessage { get; }

        public bool HasCurrentError => !string.IsNullOrWhiteSpace(CurrentErrorMessage);

      
    }
}
