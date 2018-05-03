CREATE TABLE [dbo].[ModifyNewSectorLabels] (
    [Language]                                             NVARCHAR (128) NOT NULL,
    [DepartingColumnHeading]                               NVARCHAR (MAX) NULL,
    [ArrivalColumnHeading]                                 NVARCHAR (MAX) NULL,
    [DurationColumnHeading]                                NVARCHAR (MAX) NULL,
    [FlightNumberColumnHeading]                            NVARCHAR (MAX) NULL,
    [PriceColumnHeading]                                   NVARCHAR (MAX) NULL,
    [UnfortunatlyWeAreUnableToMakeTheChangesYouRequested]  NVARCHAR (MAX) NULL,
    [ThisIsDueToYourSelectedOptionsNoLongerBeingAvailable] NVARCHAR (MAX) NULL,
    [ReturnToMyBooking]                                    NVARCHAR (MAX) NULL,
    [Continue]                                             NVARCHAR (MAX) NULL,
    [CompletePayment]                                      NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([Language] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);

