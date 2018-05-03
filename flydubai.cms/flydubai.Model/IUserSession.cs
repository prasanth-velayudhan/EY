using flydubai.Model.Profiles;
using flydubai.Model.Results;
using flydubai.Model.Search;

namespace flydubai.Model
{
    using flydubai.Model.Booking;
    using flydubai.Model.Journey;
    using System.Collections.Generic;

    /// <summary>
    /// interface for UserSession
    /// </summary>
    public interface IUserSession
    {
        string Token { get; set; }

        string CheckSum_AgencyMgt { get; set; }

        string CheckSum_BusLink { get; set; }

        string CheckSum_ReportsLink { get; set; }

        string FirstTimeLoginFlag { get; set; }

        string ProfileToken { get; set; }

        ProfileBase Profile { get; set; }

        AuthenticateTAUser TAProfile { get; set; }

        SearchCriteria SearchCriteria { get; set; }

        YourJourney YourJourney { get; set; }

        JourneyResults JourneyResults { get; set; }

        PassengerNameRecord PassengerNameRecord { get; set; }

        string CheckSum_EditPassengerLink { get; set; }

        //FZWR-1252
        List<JourneyPassenger> Api { get; set; }
        bool IsFFPUserLoggedIn { get; set; }
        string TierName { get; set; }
    }
}