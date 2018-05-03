using flydubai.Model.Profiles;
using flydubai.Model.Results;
using flydubai.Model.Search;

namespace flydubai.Model
{
    /// <summary>
    /// interface for RadixxSession
    /// </summary>
    public interface IRadixxSession
    {
        string Token { get; }

        string ProfileToken { get; set; }

        string UserIata { get; }

        string Iata { get; }

        string Username { get; }

        string RadixxChannelUser { get; }

        string ClientIpAddress { get;  }
    }
}