/// <summary>
/// Represents an error view model that contains information about an error.
/// </summary>
public class ErrorViewModel
{
    /// <summary>    /// Gets or sets the request ID associated with the error.
    /// </summary>
    public string? RequestId { get; set; }
    /// <summary>      /// Gets a value indicating whether the request ID should be shown.
    /// </summary>
    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    /// public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}
