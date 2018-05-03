CREATE TABLE [dbo].[GeolocatedBanners] (
    [GeolocatedBannerId] INT IDENTITY (1, 1) NOT NULL,
    [LanguageId]         INT NOT NULL,
    PRIMARY KEY CLUSTERED ([GeolocatedBannerId] ASC)
);

