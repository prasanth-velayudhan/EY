using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace flydubai.Model.Content.Labels
{
    /// <summary>
    /// Content Header Labels
    /// </summary>
    [DisplayName("Content header labels")]
    public class ContentHeaderLabels : LabelsBase
    {
        [Key]
        public int ContentHeaderLabelsId { get; set; }

        [DefaultValue("Sign in")]
        [DisplayName("Sign in link")]
        public string SignIn { get; set; }

        [DefaultValue("Welcome")]
        public string LoggedInWelcomeText { get; set; }

        [DefaultValue("Account home")]
        public string AccountHomeLink { get; set; }

        [DefaultValue("Your details")]
        public string YourDetailsLink { get; set; }

        [DefaultValue("My vouchers")]
        public string MyVouchersLink { get; set; }

        [DefaultValue("Booking history")]
        public string BookingHistoryLink { get; set; }

        [DefaultValue("Sign out")]
        [DisplayName("Sign out link")]
        public string SignOut { get; set; }

        [DefaultValue("Register")]
        [DisplayName("Register")]
        public string Register { get; set; }

        [DefaultValue("Search")]
        [DisplayName("Search label")]
        public string SearchLabel { get; set; }

        [DefaultValue("Follow us")]
        [DisplayName("Follow us")]
        public string FollowUs { get; set; }

        [DefaultValue("Change language")]
        [DisplayName("Change language")]
        public string ChangeLanguage { get; set; }

        [DefaultValue("Home")]
        [DisplayName("1. Top level menu - home")]
        public string MenuHome { get; set; }

        [DefaultValue("Plan")]
        [DisplayName("2. Top level menu - plan")]
        public string MenuPlan { get; set; }

        [DefaultValue("Travel")]
        [DisplayName("3. Top level menu - travel")]
        public string MenuTravel { get; set; }

        [DefaultValue("Special offers")]
        [DisplayName("4. Top level menu - special offers")]
        public string MenuSpecialOffers { get; set; }

        [DefaultValue("About us")]
        [DisplayName("5. Top level menu - about us")]
        public string MenuAboutUs { get; set; }

        [DefaultValue("News")]
        [DisplayName("6. Top level menu - news")]
        public string MenuNews { get; set; }

        [DefaultValue("Contact us")]
        [DisplayName("7. Top level menu - contact us")]
        public string MenuContactUs { get; set; }

        [DefaultValue("Search")]
        [DisplayName("Breadcrumb - search")]
        public string Search { get; set; }

        [DefaultValue("Fare types")]
        [DisplayName("Breadcrumb - fare types")]
        public string FareTypes { get; set; }

        [DefaultValue("Ways to pay")]
        [DisplayName("Breadcrumb - ways to pay")]
        public string WaysToPay { get; set; }

        [DefaultValue("Payment partners")]
        [DisplayName("Breadcrumb - payment partners")]
        public string PaymentPartners { get; set; }

        [DefaultValue("Destinations")]
        [DisplayName("Breadcrumb - destinations")]
        public string Destinations { get; set; }

        [DefaultValue("Connections")]
        [DisplayName("Breadcrumb - connections")]
        public string Connections { get; set; }

        [DefaultValue("Timetables")]
        [DisplayName("Breadcrumb - timetables")]
        public string Timetables { get; set; }

        [DefaultValue("Baggage policy")]
        [DisplayName("Breadcrumb - baggage policy")]
        public string BaggagePolicy { get; set; }

        [DefaultValue("Airports")]
        [DisplayName("Breadcrumb - airports")]
        public string Airports { get; set; }

        [DefaultValue("Flight status")]
        [DisplayName("Breadcrumb - Flight status")]
        public string FlightStatus { get; set; }

        [DefaultValue("flydubai experience")]
        [DisplayName("Breadcrumb - flydubai experience")]
        public string FlyDubaiExperience { get; set; }

        [DefaultValue("Inflight entertainment")]
        [DisplayName("Breadcrumb - inflight entertainment")]
        public string InflightEntertainment { get; set; }

        [DefaultValue("Insurance")]
        [DisplayName("Breadcrumb - insurance")]
        public string Insurance { get; set; }

        [DefaultValue("UAE visas")]
        [DisplayName("Breadcrumb - UAE visas")]
        public string UaeVisas { get; set; }

        [DefaultValue("Hotel/car hire")]
        [DisplayName("Breadcrumb - hotel/car hire")]
        public string HotelCarHire { get; set; }

        [DefaultValue("Payment locator")]
        [DisplayName("Breadcrumb - payment locator")]
        public string PaymentLocator { get; set; }

        [DefaultValue("Policies")]
        [DisplayName("Breadcrumb - policies")]
        public string Policies { get; set; }

        [DefaultValue("Latest news")]
        [DisplayName("Breadcrumb - latest news")]
        public string LatestNews { get; set; }

        [DefaultValue("Related news")]
        [DisplayName("Breadcrumb - related news")]
        public string RelatedNews { get; set; }

        [DefaultValue("News article")]
        [DisplayName("Breadcrumb - news article")]
        public string NewsArticle { get; set; }

        [DefaultValue("Press room")]
        [DisplayName("Breadcrumb - press room")]
        public string PressRoom { get; set; }

        [DefaultValue("Global PR contacts")]
        [DisplayName("Breadcrumb - global PR contacts")]
        public string GlobalPrContacts { get; set; }

        [DefaultValue("Travel agent locations")]
        [DisplayName("Breadcrumb - travel agent locations")]
        public string TravelAgentLocations { get; set; }

        [DefaultValue("FAQs")]
        [DisplayName("Breadcrumb - FAQs")]
        public string Faqs { get; set; }

        [DefaultValue("Contact us")]
        [DisplayName("Breadcrumb - contact us")]
        public string ContactUs { get; set; }

        [DefaultValue("About flydubai")]
        [DisplayName("Breadcrumb - about flydubai")]
        public string AboutFlydubai { get; set; }

        [DefaultValue("Partners")]
        [DisplayName("Breadcrumb - partners")]
        public string Partners { get; set; }

        [DefaultValue("flydubai cargo")]
        [DisplayName("Breadcrumb - flydubai cargo")]
        public string FlydubaiCargo { get; set; }

        //FFP Changes
        [DefaultValue("Points")]
        public string Points { get; set; }

        [DefaultValue("Dashboard")]
        public string RewardsLink { get; set; }

        [DefaultValue("Profile")]
        public string ProfileLink { get; set; }

        [DefaultValue("Bookings")]
        public string BookingsLink { get; set; }

        [DefaultValue("Vouchers")]
        public string VouchersLink { get; set; }

        [DefaultValue("Points")]
        public string PointsLink { get; set; }

        [DefaultValue("About Frequent Flyer")]
        public string AboutFrequentFlyerLink { get; set; }        
    }
}
