namespace Ey.Common.Contracts.Model
{
    /// <summary>
    /// TelephoneCountryCode Interface
    /// </summary>
    public interface ITelephoneCountryCode
    {
        int CountryCodeId { get; set; }
        string Language { get; set; }
        string Key { get; set; }
        string Value { get; set; }
    }
}