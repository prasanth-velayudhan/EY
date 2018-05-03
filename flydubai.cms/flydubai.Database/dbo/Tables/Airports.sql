CREATE TABLE [dbo].[Airports] (
    [AirportCode]                   NVARCHAR (3)   NOT NULL,
    [Lat]                           FLOAT (53)     NULL,
    [Long]                          FLOAT (53)     NULL,
    [CurrencyCode]                  NVARCHAR (3)   NULL,
    [OffsetFromGMT]                 NVARCHAR (MAX) NULL,
    [AdvancedPassengerInfoRequired] BIT            NOT NULL,
    [Country_CountryId]             INT            NULL,
    [Active]                        BIT            CONSTRAINT [DF_AirportCode_Active] DEFAULT ((1)) NOT NULL,
    [MetroCode]                     NVARCHAR (3)   NULL,
    [MetroActive]                   BIT            CONSTRAINT [DF_Airport_MetroActive] DEFAULT ((0)) NOT NULL,
    [isActive]                      BIT            NULL,
    PRIMARY KEY CLUSTERED ([AirportCode] ASC),
    CONSTRAINT [Airport_Country] FOREIGN KEY ([Country_CountryId]) REFERENCES [dbo].[Countries] ([CountryId])
);









