CREATE TABLE [dbo].[Cities] (
    [CityId]             INT            IDENTITY (1, 1) NOT NULL,
    [CountryId]          INT            NOT NULL,
    [CMSEnglishCityName] NVARCHAR (MAX) NULL,
    [IsActive]           BIT            DEFAULT ((1)) NOT NULL,
    PRIMARY KEY CLUSTERED ([CityId] ASC)
);



