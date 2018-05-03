using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Validation;
using flydubai.Common.Exceptions;
using flydubai.Common.Model;
using flydubai.Common.Resources;
using flydubai.Model;
using flydubai.Model.Booking;
using flydubai.Model.Common;
using flydubai.Model.Content;
using flydubai.Model.Content.Labels;
using flydubai.Model.Labels;
using flydubai.Model.Mobile;
using flydubai.Model.Profiles;
using Splendid.Data.Mapper;
using flydubai.Model.Content.Analytics;
using flydubai.Model.Beta;
using flydubai.Model.Survey;
using flydubai.Model.Currency;
using flydubai.Model.Mpesa;


namespace flydubai.DatabaseServices
{
    /// <summary>
    /// Entity Framework context to retrieve and save into the database
    /// </summary>
    /// <remarks></remarks>
    public class FlydubaiContext : BaseCmsContext
    {
        public FlydubaiContext()
        {
            // EF Code First DB initialisation strategy
            Database.SetInitializer<FlydubaiContext>(new FlyDubaiContextInitialiser());
        }

        public DbSet<Airport> Airports { get; set; }

        public DbSet<AirlineCarriers> AirlineCarriers { get; set; }
        public DbSet<AirlineCarrierLocalised> AirlineCarrierLocaliseds { get; set; }
        
        public DbSet<AirportDestination> AirportDestinations { get; set; }

        public DbSet<AirportLocalised> AirportLocaliseds { get; set; }

        public DbSet<AirportInformation> AirportInformation { get; set; }
        public DbSet<AirportInformationVersion> AirportInformationVersion { get; set; }
        
        public DbSet<DestinationGuideVersion> DestinationGuideVersion { get; set; }
        public DbSet<DestinationGuide> DestinationGuide { get; set; }
        
        public DbSet<SpecialOffer> SpecialOffer { get; set; }
        public DbSet<SpecialOfferVersion> SpecialOfferVersion { get; set; }

        public DbSet<Event> Event { get; set; }
        public DbSet<EventVersion> EventVersion { get; set; }

        public DbSet<PromotionalTeaser> PromotionalTeaser { get; set; }
        public DbSet<PromotionalTeaserVersion> PromotionalTeaserVersion { get; set; }

        public DbSet<RouteMessage> RouteMessage { get; set; }
        public DbSet<RouteMessageVersion> RouteMessageVersion { get; set; }

        public DbSet<NewsArticle> NewsArticle { get; set; }
        public DbSet<NewsArticleVersion> NewsArticleVersion { get; set; }

        public DbSet<PressGalleryImage> PressGalleryImage { get; set; }
        public DbSet<PressGalleryImageVersion> PressGalleryImageVersion { get; set; }

        public DbSet<PressGalleryVideo> PressGalleryVideo { get; set; }
        public DbSet<PressGalleryVideoVersion> PressGalleryVideoVersion { get; set; }

        public DbSet<GlobalPRContact> GlobalPRContact { get; set; }
        public DbSet<GlobalPRContactVersion> GlobalPRContactVersion { get; set; }

        public DbSet<GeolocatedBanner> GeolocatedBanner { get; set; }
        public DbSet<GeolocatedBannerVersion> GeolocatedBannerVersion { get; set; }

        public DbSet<ExperienceCategory> ExperienceCategory { get; set; }
        public DbSet<ExperienceCategoryVersion> ExperienceCategoryVersion { get; set; }

        public DbSet<Magazine> Magazine { get; set; }
        public DbSet<MagazineVersion> MagazineVersion { get; set; }

        public DbSet<PaymentPoint> PaymentPoint { get; set; }
        public DbSet<PaymentPointVersion> PaymentPointVersion { get; set; }

        public DbSet<TravelAgent> TravelAgent { get; set; }
        public DbSet<TravelAgentVersion> TravelAgentVersion { get; set; }

        public DbSet<ContactSubject> ContactSubject { get; set; }
        public DbSet<ContactSubjectVersion> ContactSubjectVersion { get; set; }

        public DbSet<UaeVisas> UaeVisas { get; set; }
        public DbSet<UaeVisasVersion> UaeVisasVersion { get; set; }

        public DbSet<Faq> Faq { get; set; }
        public DbSet<FaqVersion> FaqVersion { get; set; }

        public DbSet<MenuItem> MenuItem { get; set; }
        public DbSet<MenuItemVersion> MenuItemVersion { get; set; }

        public DbSet<CareersMenuItem> CareersMenuItem { get; set; }
        public DbSet<CareersMenuItemVersion> CareersMenuItemVersion { get; set; }

        public DbSet<FooterItem> FooterItem { get; set; }
        public DbSet<FooterItemVersion> FooterItemVersion { get; set; }

        public DbSet<CareersFooter> CareersFooter { get; set; }
        public DbSet<CareersFooterVersion> CareersFooterVersion { get; set; }

        public DbSet<InflightMovie> InflightMovie { get; set; }
        public DbSet<InflightMovieVersion> InflightMovieVersion { get; set; }

        public DbSet<InflightEntertainment> InflightEntertainment { get; set; }
        public DbSet<InflightEntertainmentVersion> InflightEntertainmentVersion { get; set; }

        public DbSet<SpecialOfferVersionAirport> SpecialOfferVersionAirport { get; set; }

        public DbSet<ExceptionMessage> ExceptionMessages { get; set; }

        public DbSet<FlightSearchLabels> FlightSearchLabels { get; set; }
        
        public DbSet<OptionalExtrasLabels> OptionalExtrasLabels { get; set; }

        public DbSet<YourJourneyLabels> YourJourneyLabels { get; set; }

        public DbSet<ResultsLabels> ResultsLabels { get; set; }

        public DbSet<ResultsTabLabels> ResultsTabLabels { get; set; }

        public DbSet<PaymentLabels> PaymentLabels { get; set; }

        public DbSet<ConfirmationLabels> ConfirmationLabels { get; set; }
        
        public DbSet<PassengerDetailsLabels> PassengerDetailsLabels { get; set; }

        public DbSet<VoucherLabels> VoucherLabels { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<CountryLocalised> CountiesLocalised { get; set; }

        public DbSet<HandBaggage> HandBaggage { get; set; }

        public DbSet<BusinessHandBaggage> BusinessHandBaggage { get; set; } //Added by a-5467 - Platinum changes

        public DbSet<SignUpPreferences> SignUpPreferences { get; set; }

        public DbSet<ExceptionMessageArea> ExceptionMessageAreas { get; set; }

        public DbSet<BookingWizardLabels> BookingWizardLabels { get; set; }

        public DbSet<BookingLabels> BookingLabels { get; set; }

        public DbSet<AccountLabels> AccountLabels { get; set; }

        public DbSet<ErrorLabels> ErrorLabels { get; set; }

        public DbSet<CodeType> CodeTypes { get; set; }

        public DbSet<TierType> TierTypes { get; set; }

        public DbSet<CodeTypeLocalised> CodeTypeLocaliseds { get; set; }

        public DbSet<CodeTypeCategory> CodeTypeCategories { get; set; }

        public DbSet<BookingHistoryLabels> BookingHistoryLabels { get; set; }

        public DbSet<DepartureWindow> DepartureWindows { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<CityLocalised> CitiesLocalised { get; set; }

        public DbSet<Log> Log { get; set; }

        public DbSet<RouteMessageLabels> RouteMessageLabels { get; set; }

        public DbSet<IFESSRCode> IFESSRCode { get; set; }

        public DbSet<TAAccountLabels> TAAccountLabels { get; set; }       

        public DbSet<TAReportSearchLabels> TAReportSearchLabels { get; set; }

        public DbSet<TAViewReportSearchLabels> ReportSearchLabels { get; set; }

        public DbSet<TAViewBalanceReportLabels> ViewBalanceReportLabels { get; set; }

        public DbSet<SeatMapping> SeatMapping { get; set; }

        public DbSet<PaymentTypes> PaymentTypes { get; set; }

        //public DbSet<MpesaSettings> MpesaSettings { get; set; }

        public DbSet<SessionMessage> SessionMessage { get; set; }

        //public DbSet<PreSellMealLocalised>PreSellMealLocaliseds { get; set; }
        public DbSet<MonthLocalised> MonthLocaliseds { get; set; }

        public DbSet<flydubai.Model.ExternalPricing.CompanionFareConfigs> CompanionFareConfigs { get; set; }

        //public DbSet<AiportUpdatedDateTime> AiportUpdatedDateTime { get; set; }

        #region CMS content

        public DbSet<Contingency> ContingencyStatements { get; set; }
        public DbSet<ContingencyUpdate> ContingencyUpdates { get; set; }
        public DbSet<CustomPage> CustomPages { get; set; }
        public DbSet<CustomPageLocalised> CustomPagesLocaliseds { get; set; }
        public DbSet<CustomErrorPage> CustomErrorPages { get; set; }
        public DbSet<DestinationCategory> DestinationCategories { get; set; }
        public DbSet<Emergency> EmergencyStatements { get; set; }
        public DbSet<EmergencyUpdate> EmergencyUpdates { get; set; }
        public DbSet<IpCountryMapping> IpCountryMappings { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<WebsiteSetting> WebsiteSettings { get; set; }
        public DbSet<Media> Media { get; set; }
        public DbSet<MediaCategory> MediaCategories { get; set; }
        public DbSet<OperationalUpdate> OperationalUpdates { get; set; }
        public DbSet<FareType> FareTypes { get; set; }
        public DbSet<GoogleAnalytics> GoogleAnalytics { get; set; }
        public DbSet<InterceptLightBox> InterceptLightBox { get; set; }
        public DbSet<UniquePageTitle> UniquePageTitle { get; set; }
        public DbSet<SurveyLightBox> SurveyLightBox { get; set; }
        public DbSet<CurrencySetting> CurrencySetting { get; set; }
        public DbSet<MpesaSetting> MpesaSetting { get; set; }
       // public DbSet<PreSellMeal> PreSellMeals { get; set; } //a-5466
        public DbSet<FareBrandIDLabel> FareBrandIDLabels { get; set; }

        //A-5446 WR7 - Auto Include SSR
        public DbSet<TAAutoIncludeConfig> TAAutoIncludeConfigs { get; set; }

        public DbSet<CustomPageAccessData> CustomPageAccessDatas { get; set; }
        public DbSet<OFEEConfig> OFEEConfigs { get; set; }      //OFEE changes

        public DbSet<ReaccomWindows> ReaccomWindowsConfigs { get; set; }  

        #endregion

        #region Mobile content

        public DbSet<MobileAccountLabels> MobileAccountLabels { get; set; }
        public DbSet<MobileCommonLabels> MobileCommonLabels { get; set; }
        public DbSet<MobileConfirmationLabels> MobileConfirmationLabels { get; set; }
        public DbSet<MobileFareTypeLabels> MobileFareTypeLabels { get; set; }
        public DbSet<MobileHomeLabels> MobileHomeLabels { get; set; }
        public DbSet<MobileOptionalExtrasLabels> MobileOptionalExtras { get; set; }
        public DbSet<MobilePassengerLabels> MobilePassengerLabels { get; set; }
        public DbSet<MobilePaymentLabels> MobilePaymentLabels { get; set; }
        public DbSet<MobileResultsLabels> MobileResultsLabels { get; set; }
        public DbSet<MobileSearchLabels> MobileSearchLabels { get; set; }
        public DbSet<MobileNonBookingLabels> MobileNonBookingLabels { get; set; }
        public DbSet<MobileViewTicketLabels> MobileViewTicketLabels { get; set; }
        public DbSet<MobileContactUsLabels> MobileContactUsLabels { get; set; }
        public DbSet<MobileErrorLabels> MobileErrorLabels { get; set; }

        #endregion

        #region Content Website Labels

        public DbSet<AirportInformationLabels> AirportInformationLabels { get; set; }
        public DbSet<ContentHeaderLabels> ContentHeaderLabels { get; set; }
        public DbSet<DateTimeLabels> DateTimeLabels { get; set; }
        public DbSet<DestinationGuideLabels> DestinationGuideLabels { get; set; }
        public DbSet<EmergencyHeaderLabels> EmergencyHeaderLabels { get; set; }
        public DbSet<EmergencyContentLabels> EmergencyContentLabels { get; set; }
        public DbSet<ExperienceLabels> ExperienceLabels { get; set; }
        public DbSet<NewsArticleLabels> NewsArticleLabels { get; set; }
        public DbSet<QuickLinksLabels> QuickLinksLabels { get; set; }
        public DbSet<WhereWeFlyLabels> WhereWeFlyLabels { get; set; }
        public DbSet<InflightEntertainmentLabels> InflightEntertainmentLabels { get; set; }
        public DbSet<PaymentPointLabels> PaymentPointLabels { get; set; }
        public DbSet<FaqLabels> FaqLabels { get; set; }
        public DbSet<GlobalPRContactLabels> GlobalPRContactLabels { get; set; }
        public DbSet<PressContactSummaryLabels> PressContactSummaryLabels { get; set; }
        public DbSet<WaysToPayLabels> WaysToPayLabels { get; set; }
        public DbSet<HowToBookLabels> HowToBookLabels { get; set; }
        public DbSet<FlightStatusLabels> FlightStatusLabels { get; set; }
        public DbSet<ValidationLabels> ValidationLabels { get; set; }
        public DbSet<TravelAgentLabels> TravelAgentLabels { get; set; }
        public DbSet<CareersLabels> CareersLabels { get; set; }
        public DbSet<MediaDownloadsLabels> MediaDownloadsLabels { get; set; }
        public DbSet<FareTypeLabels> FareTypeLabels { get; set; }
        public DbSet<SpecialOfferLabels> SpecialOfferLabels { get; set; }
        public DbSet<EventLabels> EventLabels { get; set; }
        public DbSet<UaeVisasLabels> UaeVisasLabels { get; set; }
        public DbSet<SignUpLabels> SignUpLabels { get; set; }
        public DbSet<CareersHeaderLabels> CareersHeaderLabels { get; set; }
        public DbSet<PressGalleryLabels> PressGalleryLabels { get; set; }
        public DbSet<ContactUsLabels> ContactUsLabels { get; set; }
        public DbSet<NetworkWithUsLabels> NetworkWithUsLabels { get; set; }
        public DbSet<MagazineLabels> MagazineLabels { get; set; }
        public DbSet<SiteSearchLabels> SiteSearchLabels { get; set; }
        public DbSet<SiteSearchCategoryLabels> SiteSearchCategoryLabels { get; set; }
        public DbSet<FlightSearchContentLabels> FlightSearchContentLabels { get; set; }
        public DbSet<BusServiceLabels> BusServiceLabels { get; set; }
        public DbSet<TimetableLabels> TimetableLabels { get; set; }
        public DbSet<OperationalUpdateLabels> OperationalUpdateLabels { get; set; }
        public DbSet<CarHireLabels> CarHireLabels { get; set; }
        public DbSet<ConnectionSearchLabels> ConnectionSearchLabels { get; set; }
        public DbSet<OLCIWidgetLabels> OLCIWidgetLabels { get; set; }

        #endregion

        #region Booking Website Labels

        public DbSet<SharedLabels> SharedLabels { get; set; }
        public DbSet<ModifyCancelBookingLabels> ModifyCancelBookingLabels { get; set; }
        public DbSet<ModifyCancelSectorLabels> ModifyCancelSectorLabels { get; set; }
        public DbSet<ModifyChangeDateLabels> ModifyChangeDateLabels { get; set; }
        public DbSet<ModifyRepeatBookingLabels> ModifyRepeatBookingLabels { get; set; }
        public DbSet<ModifyProgressBarLabels> ModifyProgressBarLabels { get; set; }
        public DbSet<ModifyAddPassengersLabels> ModifyAddPassengersLabels { get; set; }
        public DbSet<ModifyAddPassengersFlightSummaryLabels> ModifyAddPassengersFlightSummaryLabels { get; set; }
        public DbSet<ModifyAddPassengersDetailsLabels> ModifyAddPassengersDetailsLabels { get; set; }
        public DbSet<ModifyAddPassengersOptionalExtrasLabels> ModifyAddPassengersOptionalExtrasLabels { get; set; }
        public DbSet<ModifyChangeDateResultsLabels> ModifyChangeDateResultsLabels { get; set; }
        public DbSet<ModifyPassengerLimitReachedLabels> ModifyPassengerLimitReachedLabels { get; set; }
        public DbSet<ModifyOptionalExtrasLabels> ModifyOptionalExtrasLabels { get; set; }
        public DbSet<ModifyNewSectorLabels> ModifyNewSectorLabels { get; set; }
        public DbSet<ModifyChangeDateOptionalExtrasLabels> ModifyChangeDateOptionalExtrasLabels { get; set; }
        public DbSet<ModifyRemovePassengerLabels> ModifyRemovePassengerLabels { get; set; }
        public DbSet<ShowAmendmentsLabels> ShowAmendmentsLabels { get; set; }
        public DbSet<ManageBookingTabLabels> ManageBookingTabLabels { get; set; }
        public DbSet<ManageBookingNarrowTabLabels> ManageBookingNarrowTabLabels { get; set; }
        public DbSet<FlightSearchTabLabels> FlightSearchTabLabels { get; set; }
        public DbSet<FlightSearchNarrowTabLabels> FlightSearchNarrowTabLabels { get; set; }

        #endregion

        public DbSet<GSTTypesLabels> GSTTypesLabels { get; set; }

        /// <summary>
        /// Saves all changes made in this context to the underlying database.
        /// </summary>
        /// <returns>The number of objects written to the underlying database.</returns>
        /// <exception cref="T:System.InvalidOperationException">Thrown if the context has been disposed.</exception>
        /// <remarks></remarks>
        public override int SaveChanges()
        {
            try
            {
                return base.SaveChanges();
            }
            catch (DbEntityValidationException dbException)
            {
                FlyDubaiDataException flyDubaiDataException = new FlyDubaiDataException(Messages.SaveChangesError);
                foreach (var validationErrors in dbException.EntityValidationErrors)
                {
                    var entityException = new FlyDubaiEntityException(validationErrors.Entry.Entity.ToString());

                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        entityException.EntityPropertyExceptions.Add(
                            new FlyDubaiEntityPropertyException(
                                validationError.PropertyName,
                                validationErrors.Entry.CurrentValues[validationError.PropertyName].ToString(),
                                validationError.ErrorMessage));
                    }

                    flyDubaiDataException.EntityExceptions.Add(entityException);
                }

                throw flyDubaiDataException;
            }
        }

        /// <summary>
        /// This method is called when the model for a derived context has been initialized, but
        /// before the model has been locked down and used to initialize the context.  The default
        /// implementation of this method does nothing, but it can be overridden in a derived class
        /// such that the model can be further configured before it is locked down.
        /// </summary>
        /// <param name="modelBuilder">The builder that defines the model for the context being created.</param>
        /// <remarks></remarks>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OFEEConfig>().Property(x => x.OFEE).HasPrecision(18, 3);    //OFEE changes
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<IncludeMetadataConvention>();

            modelBuilder.Entity<AirportInformation>().Map(x => x.MapInheritedProperties());
            modelBuilder.Entity<AirportInformationVersion>().Map(x => x.MapInheritedProperties());
            modelBuilder.Entity<DestinationGuide>().Map(x => x.MapInheritedProperties());
            modelBuilder.Entity<DestinationGuideVersion>().Map(x => x.MapInheritedProperties());
            modelBuilder.Entity<Event>().Map(x => x.MapInheritedProperties());
            modelBuilder.Entity<EventVersion>().Map(x => x.MapInheritedProperties());
            modelBuilder.Entity<RouteMessage>().Map(x => x.MapInheritedProperties());
            modelBuilder.Entity<RouteMessageVersion>().Map(x => x.MapInheritedProperties());
            modelBuilder.Entity<GeolocatedBanner>().Map(x => x.MapInheritedProperties());
            modelBuilder.Entity<GeolocatedBannerVersion>().Map(x => x.MapInheritedProperties());
            modelBuilder.Entity<NewsArticle>().Map(x => x.MapInheritedProperties());
            modelBuilder.Entity<NewsArticleVersion>().Map(x => x.MapInheritedProperties());
            modelBuilder.Entity<SpecialOffer>().Map(x => x.MapInheritedProperties());
            modelBuilder.Entity<SpecialOfferVersion>().Map(x => x.MapInheritedProperties());
            modelBuilder.Entity<InflightMovie>().Map(x => x.MapInheritedProperties());
            modelBuilder.Entity<InflightMovieVersion>().Map(x => x.MapInheritedProperties());
            modelBuilder.Entity<InflightEntertainment>().Map(x => x.MapInheritedProperties());
            modelBuilder.Entity<InflightEntertainmentVersion>().Map(x => x.MapInheritedProperties());
            modelBuilder.Entity<PaymentPoint>().Map(x => x.MapInheritedProperties());
            modelBuilder.Entity<PaymentPointVersion>().Map(x => x.MapInheritedProperties());
            modelBuilder.Entity<Faq>().Map(x => x.MapInheritedProperties());
            modelBuilder.Entity<FaqVersion>().Map(x => x.MapInheritedProperties());
            modelBuilder.Entity<GlobalPRContact>().Map(x => x.MapInheritedProperties());
            modelBuilder.Entity<GlobalPRContactVersion>().Map(x => x.MapInheritedProperties());
            modelBuilder.Entity<MenuItem>().Map(x => x.MapInheritedProperties());
            modelBuilder.Entity<MenuItemVersion>().Map(x => x.MapInheritedProperties());
            modelBuilder.Entity<TravelAgent>().Map(x => x.MapInheritedProperties());
            modelBuilder.Entity<TravelAgentVersion>().Map(x => x.MapInheritedProperties());
            modelBuilder.Entity<UaeVisas>().Map(x => x.MapInheritedProperties());
            modelBuilder.Entity<UaeVisasVersion>().Map(x => x.MapInheritedProperties());
            modelBuilder.Entity<CareersMenuItem>().Map(x => x.MapInheritedProperties());
            modelBuilder.Entity<CareersMenuItemVersion>().Map(x => x.MapInheritedProperties());
            modelBuilder.Entity<FooterItem>().Map(x => x.MapInheritedProperties());
            modelBuilder.Entity<FooterItemVersion>().Map(x => x.MapInheritedProperties());
            modelBuilder.Entity<PressGalleryImage>().Map(x => x.MapInheritedProperties());
            modelBuilder.Entity<PressGalleryImageVersion>().Map(x => x.MapInheritedProperties());
            modelBuilder.Entity<PressGalleryVideo>().Map(x => x.MapInheritedProperties());
            modelBuilder.Entity<PressGalleryVideoVersion>().Map(x => x.MapInheritedProperties());
            modelBuilder.Entity<Magazine>().Map(x => x.MapInheritedProperties());
            modelBuilder.Entity<MagazineVersion>().Map(x => x.MapInheritedProperties());
            modelBuilder.Entity<ContactSubject>().Map(x => x.MapInheritedProperties());
            modelBuilder.Entity<ContactSubjectVersion>().Map(x => x.MapInheritedProperties());
            modelBuilder.Entity<ExperienceCategory>().Map(x => x.MapInheritedProperties());
            modelBuilder.Entity<ExperienceCategoryVersion>().Map(x => x.MapInheritedProperties());
            modelBuilder.Entity<PromotionalTeaser>().Map(x => x.MapInheritedProperties());
            modelBuilder.Entity<PromotionalTeaserVersion>().Map(x => x.MapInheritedProperties());
            modelBuilder.Entity<CareersFooter>().Map(x => x.MapInheritedProperties());
            modelBuilder.Entity<CareersFooterVersion>().Map(x => x.MapInheritedProperties());
            modelBuilder.Entity<GoogleAnalytics>().Map(x => x.MapInheritedProperties());
            modelBuilder.Entity<InterceptLightBox>().Map(x => x.MapInheritedProperties());
            modelBuilder.Entity<UniquePageTitle>().Map(x => x.MapInheritedProperties());
            modelBuilder.Entity<SurveyLightBox>().Map(x => x.MapInheritedProperties());
            modelBuilder.Entity<CurrencySetting>().Map(x => x.MapInheritedProperties());
            modelBuilder.Entity<MpesaSetting>().Map(x => x.MapInheritedProperties());
            modelBuilder.Entity<TAAutoIncludeConfig>().Map(x => x.MapInheritedProperties());

            modelBuilder.Entity<SessionMessage>().Map(x => x.MapInheritedProperties());

            modelBuilder.Entity<ScheduledFlightSubscription>().Map(x => x.MapInheritedProperties());            

            modelBuilder.Entity<CallCentre>().Map(x => x.MapInheritedProperties());
            modelBuilder.Entity<CallCentreVersion>().Map(x => x.MapInheritedProperties());

            modelBuilder.Entity<EventVersion>()
                .HasMany(x => x.Airports)
                .WithMany()
                .Map(x =>
                {
                    x.ToTable("EventVersionAirport");
                    x.MapLeftKey("EventVersionId");
                    x.MapRightKey("AirportCode");
                });

            modelBuilder.Entity<DestinationGuide>()
                .HasMany(x => x.AirportLocaliseds)
                .WithOptional()
                .HasForeignKey(x => x.DestinationGuideId);

            modelBuilder.Entity<DestinationGuideVersion>()
                .HasMany(x => x.DestinationCategories)
                .WithMany(x => x.DestinationGuideVersions)
                .Map(x =>
                {
                    x.ToTable("DestinationGuideVersionCategory");
                    x.MapLeftKey("DestinationGuideVersionId");
                    x.MapRightKey("DestinationCategoryId");
                });

            modelBuilder.Entity<Member>()
                .HasMany(x => x.Roles)
                .WithMany(x => x.Members)
                .Map(x =>
                {
                    x.ToTable("MemberRole");
                    x.MapLeftKey("MemberId");
                    x.MapRightKey("RoleId");
                });

            modelBuilder.Entity<SpecialOfferVersion>()
                .HasMany(x => x.Airports)
                .WithMany()
                .Map(x =>
                {
                    x.ToTable("SpecialOfferVersionAirport");
                    x.MapLeftKey("SpecialOfferVersionId");
                    x.MapRightKey("AirportCode");
                });

            modelBuilder.Entity<NewsArticleVersion>()
                .HasMany(x => x.Tags)
                .WithMany()
                .Map(x =>
                {
                    x.ToTable("NewsArticleVersionTag");
                    x.MapLeftKey("NewsArticleVersionId");
                    x.MapRightKey("NewsArticleTagId");
                });

            modelBuilder.Entity<Airport>()
                .HasMany(x => x.Destinations)
                .WithRequired(x => x.OriginAirport)
                .HasForeignKey(x => x.OriginAirportCode);

            modelBuilder.Entity<Airport>()
                .HasMany(x => x.Destinations)
                .WithRequired(x => x.OriginAirport)
                .HasForeignKey(x => x.OriginAirportCode);

            modelBuilder.Entity<ExperienceCategoryVersion>()
                .HasMany(x => x.Images)
                .WithMany();


        }

        /// <summary>
        /// Detaches the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <remarks></remarks>
        public void Detach(object entity)
        {
            ((IObjectContextAdapter)this).ObjectContext.Detach(entity);
        }
    }
}
