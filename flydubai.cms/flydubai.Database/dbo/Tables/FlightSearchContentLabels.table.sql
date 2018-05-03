CREATE TABLE [dbo].[FlightSearchContentLabels] (
    [FlightSearchContentLabelsId]     INT            IDENTITY (1, 1) NOT NULL,
    [FlightSearch]                    NVARCHAR (MAX) NULL,
    [ManageBooking]                   NVARCHAR (MAX) NULL,
    [PleaseSelectOriginAirport]       NVARCHAR (MAX) NULL,
    [PleaseWaitWhileWeCheckForLowest] NVARCHAR (MAX) NULL,
    [LoadingResults]                  NVARCHAR (MAX) NULL,
    [NoAirportsFound]                 NVARCHAR (MAX) NULL,
    [Loading]                         NVARCHAR (MAX) NULL,
    [PleaseWait]                      NVARCHAR (MAX) NULL,
    [LanguageId]                      INT            NOT NULL,
    [PleaseTrySearchAgain]            NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([FlightSearchContentLabelsId] ASC)
);



