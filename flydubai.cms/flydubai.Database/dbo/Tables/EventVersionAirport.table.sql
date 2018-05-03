CREATE TABLE [dbo].[EventVersionAirport] (
    [EventVersionId] INT          NOT NULL,
    [AirportCode]    NVARCHAR (3) NOT NULL,
    PRIMARY KEY CLUSTERED ([EventVersionId] ASC, [AirportCode] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);

