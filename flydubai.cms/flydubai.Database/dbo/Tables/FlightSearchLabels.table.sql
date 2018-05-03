﻿CREATE TABLE [dbo].[FlightSearchLabels] (
    [Language]                               NVARCHAR (128) NOT NULL,
    [ForSpecialNeedsMinorsPetsPolicy]        NVARCHAR (MAX) NULL,
    [PleaseCheckTheseDetailsAreCorrect]      NVARCHAR (MAX) NULL,
    [FlightSearch]                           NVARCHAR (MAX) NULL,
    [ManageBooking]                          NVARCHAR (MAX) NULL,
    [Roundtrip]                              NVARCHAR (MAX) NULL,
    [OneWay]                                 NVARCHAR (MAX) NULL,
    [FlyingFrom]                             NVARCHAR (MAX) NULL,
    [From]                                   NVARCHAR (MAX) NULL,
    [FlyingTo]                               NVARCHAR (MAX) NULL,
    [To]                                     NVARCHAR (MAX) NULL,
    [AddMultipleDestinations]                NVARCHAR (MAX) NULL,
    [FlyingOutOn]                            NVARCHAR (MAX) NULL,
    [FlyingBackOn]                           NVARCHAR (MAX) NULL,
    [FlexibleOnDates]                        NVARCHAR (MAX) NULL,
    [Passengers]                             NVARCHAR (MAX) NULL,
    [Adults]                                 NVARCHAR (MAX) NULL,
    [Children]                               NVARCHAR (MAX) NULL,
    [Infants]                                NVARCHAR (MAX) NULL,
    [MakeBookingOf9OrMore]                   NVARCHAR (MAX) NULL,
    [PromotionalCode]                        NVARCHAR (MAX) NULL,
    [PromotionalCodeTooltip]                 NVARCHAR (MAX) NULL,
    [ShowFlights]                            NVARCHAR (MAX) NULL,
    [SeeFAQ]                                 NVARCHAR (MAX) NULL,
    [MultipleDestinations]                   NVARCHAR (MAX) NULL,
    [BackToStandardFlightBooking]            NVARCHAR (MAX) NULL,
    [IAmFlyingFrom]                          NVARCHAR (MAX) NULL,
    [IAmFlyingTo]                            NVARCHAR (MAX) NULL,
    [IAmFlyingOutOn]                         NVARCHAR (MAX) NULL,
    [RemoveFlight]                           NVARCHAR (MAX) NULL,
    [AddFlight]                              NVARCHAR (MAX) NULL,
    [TwelvePlus]                             NVARCHAR (MAX) NULL,
    [Twoto12]                                NVARCHAR (MAX) NULL,
    [Under2]                                 NVARCHAR (MAX) NULL,
    [Under2Tooltip]                          NVARCHAR (MAX) NULL,
    [WantToMakeBookingOf9OrMore]             NVARCHAR (MAX) NULL,
    [WantToMakeBookingOf9OrMoreTooltip]      NVARCHAR (MAX) NULL,
    [FindOutHere]                            NVARCHAR (MAX) NULL,
    [DoYouHavePromotionalCode]               NVARCHAR (MAX) NULL,
    [OnlyOneCodeCanBeUsed]                   NVARCHAR (MAX) NULL,
    [EnterYourPromotionalCode]               NVARCHAR (MAX) NULL,
    [PleaseSelectOriginAirport]              NVARCHAR (MAX) NULL,
    [DohopConnectionSearch]                  NVARCHAR (MAX) NULL,
    [TheDohopConnectionSearch]               NVARCHAR (MAX) NULL,
    [DohopContentCopy]                       NVARCHAR (MAX) NULL,
    [ReadMore]                               NVARCHAR (MAX) NULL,
    [ConnectionSearch]                       NVARCHAR (MAX) NULL,
    [dohop]                                  NVARCHAR (MAX) NULL,
    [PleaseWaitWhileWeCheckForLowest]        NVARCHAR (MAX) NULL,
    [LoadingResults]                         NVARCHAR (MAX) NULL,
    [AMaximumOf]                             NVARCHAR (MAX) NULL,
    [TenFlights]                             NVARCHAR (MAX) NULL,
    [CanBeBookedInOneTransaction]            NVARCHAR (MAX) NULL,
    [NoAirportsFound]                        NVARCHAR (MAX) NULL,
    [PromoPlaceholder]                       NVARCHAR (MAX) NULL,
    [PromotionCode]                          NVARCHAR (MAX) NULL,
    [GroupBookingsEmail]                     NVARCHAR (MAX) NULL,
    [Email]                                  NVARCHAR (MAX) NULL,
    [GroupBookingsTelephoneNumber]           NVARCHAR (MAX) NULL,
    [Call]                                   NVARCHAR (MAX) NULL,
    [GroupBookings]                          NVARCHAR (MAX) NULL,
    [InfantPassengers]                       NVARCHAR (MAX) NULL,
    [MakeABooking]                           NVARCHAR (MAX) NULL,
    [PleaseTrySearchAgain]                   NVARCHAR (MAX) NULL,
    [TroubleWithChangeDateRadixxUnknowError] NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([Language] ASC)
);





