CREATE TABLE [dbo].[MobileResultsLabels] (
    [Language]                                NVARCHAR (128) NOT NULL,
    [SelectOutboundFlight]                    NVARCHAR (MAX) NULL,
    [SelectReturnFlight]                      NVARCHAR (MAX) NULL,
    [NoFlightsAvailableShowingClosest]        NVARCHAR (MAX) NULL,
    [NoFlightsAvailableOnThisDate]            NVARCHAR (MAX) NULL,
    [BasedOn24HourClock]                      NVARCHAR (MAX) NULL,
    [AllTimesShownAreLocal]                   NVARCHAR (MAX) NULL,
    [SortBy]                                  NVARCHAR (MAX) NULL,
    [Time]                                    NVARCHAR (MAX) NULL,
    [Price]                                   NVARCHAR (MAX) NULL,
    [PerPerson]                               NVARCHAR (MAX) NULL,
    [BackToTop]                               NVARCHAR (MAX) NULL,
    [NoFlightsFoundForSelectedDate]           NVARCHAR (MAX) NULL,
    [ShowingResultsForTheClosestAvailableDay] NVARCHAR (MAX) NULL,
    [Prev]                                    NVARCHAR (MAX) NULL,
    [Next]                                    NVARCHAR (MAX) NULL,
    [Day]                                     NVARCHAR (MAX) DEFAULT ((0)) NULL,
    [ArrivalNextDay]                          NVARCHAR (MAX) DEFAULT ((0)) NULL,
    [ArrivalNextDayTooltip]                   NVARCHAR (MAX) DEFAULT ((0)) NULL,
    [NotAvailable]                            NVARCHAR (MAX) NULL,
    [FlightStatusDiverted]                    NVARCHAR (MAX) NULL,
    [FlightStatusReRouted]                    NVARCHAR (MAX) NULL,
    [FlightStatusForcedReturnRAMP]            NVARCHAR (MAX) NULL,
    [FlightStatusForcedReturnAIR]             NVARCHAR (MAX) NULL,
    [FlightStatusNotYetDeparted]              NVARCHAR (MAX) NULL,
    [FlightStatusArrived]                     NVARCHAR (MAX) NULL,
    [FlightStatusDeparted]                    NVARCHAR (MAX) NULL,
    [FlightStatusCancelled]                   NVARCHAR (MAX) NULL,
    [FlightStatusUnknown]                     NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([Language] ASC)
);







