CREATE TABLE [dbo].[AirportDestinations] (
    [AirportDestinationId]   INT             IDENTITY (1, 1) NOT NULL,
    [OriginAirportCode]      NVARCHAR (3)    NOT NULL,
    [DestinationAirportCode] NVARCHAR (3)    NOT NULL,
    [RouteDuration]          DECIMAL (18, 2) NOT NULL,
    [IsAPIsRequired]         BIT             NOT NULL,
    PRIMARY KEY CLUSTERED ([AirportDestinationId] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);

