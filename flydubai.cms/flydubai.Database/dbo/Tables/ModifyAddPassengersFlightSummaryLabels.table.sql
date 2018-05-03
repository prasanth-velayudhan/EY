CREATE TABLE [dbo].[ModifyAddPassengersFlightSummaryLabels] (
    [Language]                  NVARCHAR (128) NOT NULL,
    [JourneyNumberLabelText]    NVARCHAR (MAX) NULL,
    [DepartureDateLabelText]    NVARCHAR (MAX) NULL,
    [FlightNumberColumnHeading] NVARCHAR (MAX) NULL,
    [DepartingColumnHeading]    NVARCHAR (MAX) NULL,
    [ArrivalColumnHeading]      NVARCHAR (MAX) NULL,
    [FareTypeColumnHeading]     NVARCHAR (MAX) NULL,
    [FareType1Name]             NVARCHAR (MAX) NOT NULL,
    [FareType2Name]             NVARCHAR (MAX) NOT NULL,
    [Adult]                     NVARCHAR (MAX) NOT NULL,
    [Children]                  NVARCHAR (MAX) NOT NULL,
    [Infant]                    NVARCHAR (MAX) NOT NULL,
    [BusinessBasic]             NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([Language] ASC)
);





