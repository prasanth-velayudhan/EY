namespace flydubai.Common.Contracts.Model
{
    /// <summary>
    /// ExceptionMessage Interface
    /// </summary>
    public interface IExceptionMessage
    {
        int ExceptionMessageId { get; set; }
        string Language { get; set; }
        string Key { get; set; }
        string Value { get; set; }
        string Area { get; set; }
    }
}