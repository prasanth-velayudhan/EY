CREATE TABLE [dbo].[MobileSearchLabels] (
    [Language]                         NVARCHAR (128) NOT NULL,
    [FlightSearch]                     NVARCHAR (MAX) NULL,
    [RoundTrip]                        NVARCHAR (MAX) NULL,
    [OneWay]                           NVARCHAR (MAX) NULL,
    [IAmFlyingFrom]                    NVARCHAR (MAX) NULL,
    [IAmFlyingTo]                      NVARCHAR (MAX) NULL,
    [IAmFlyingOutOn]                   NVARCHAR (MAX) NULL,
    [IAmFlyingBackOn]                  NVARCHAR (MAX) NULL,
    [TwoTo12]                          NVARCHAR (MAX) NULL,
    [Under2Years]                      NVARCHAR (MAX) NULL,
    [AllInfantsMustTravelWithAnAdult]  NVARCHAR (MAX) NULL,
    [DoYouHaveAPromoCode]              NVARCHAR (MAX) NULL,
    [ShowFlights]                      NVARCHAR (MAX) NULL,
    [ReEnterPromoCode]                 NVARCHAR (MAX) NULL,
    [YourPromoCodeHasBeenAccepted]     NVARCHAR (MAX) NULL,
    [ClickNextToContinue]              NVARCHAR (MAX) NULL,
    [WeAreHavingTroubleWithYourSearch] NVARCHAR (MAX) NULL,
    [BackToTop]                        NVARCHAR (MAX) NULL,
    [FlightClass]                      NVARCHAR (MAX) NULL,
    [AllCabin]                         NVARCHAR (MAX) NULL,
    [Economy]                          NVARCHAR (MAX) NULL,
    [Business]                         NVARCHAR (MAX) NULL,
    [TroubleWithSummaryPNR]            NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([Language] ASC)
);





