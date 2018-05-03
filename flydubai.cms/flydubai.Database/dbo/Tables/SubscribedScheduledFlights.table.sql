CREATE TABLE [dbo].[SubscribedScheduledFlights] (
    [SubscribedScheduledFlightId]          INT            IDENTITY (1, 1) NOT NULL,
    [CreatedDate]                          DATETIME2 (7)  NOT NULL,
    [FlightNumber]                         NVARCHAR (MAX) NULL,
    [FromAirportCode]                      NVARCHAR (MAX) NULL,
    [FromAirportName]                      NVARCHAR (MAX) NULL,
    [ToAirportCode]                        NVARCHAR (MAX) NULL,
    [ToAirportName]                        NVARCHAR (MAX) NULL,
    [FlightStatusCode]                     NVARCHAR (MAX) NULL,
    [ScheduledDeparture]                   DATETIME       NOT NULL,
    [ScheduledArrival]                     DATETIME       NOT NULL,
    [EstimatedDeparture]                   DATETIME       NULL,
    [EstimatedArrival]                     DATETIME       NULL,
    [ActualDeparture]                      DATETIME       NULL,
    [ActualArrival]                        DATETIME       NULL,
    [IsDepartureDelayed]                   BIT            NOT NULL,
    [IsArrivalDelayed]                     BIT            NOT NULL,
    [Parent_ScheduledFlightSubscriptionId] INT            NULL,
    PRIMARY KEY CLUSTERED ([SubscribedScheduledFlightId] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);

