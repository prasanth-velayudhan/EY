CREATE TABLE [dbo].[CityLocaliseds] (
    [LocalisedCityId] INT            IDENTITY (1, 1) NOT NULL,
    [Name]            NVARCHAR (MAX) NOT NULL,
    [Language]        NVARCHAR (MAX) NOT NULL,
    [City_CityId]     INT            NOT NULL
);



