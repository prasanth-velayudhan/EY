CREATE TABLE [dbo].[AirportLocaliseds] (
    [AirportLocalisedId] INT            IDENTITY (1, 1) NOT NULL,
    [AirportCode]        NVARCHAR (3)   NULL,
    [Language]           NVARCHAR (MAX) NULL,
    [AirportName]        NVARCHAR (256) NOT NULL,
    [City]               NVARCHAR (256) NULL,
    [DestinationGuideId] INT            NULL,
    [MetroName]          NVARCHAR (256) NULL,
    PRIMARY KEY CLUSTERED ([AirportLocalisedId] ASC),
);



