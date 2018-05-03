CREATE TABLE [dbo].[CountryLocaliseds] (
    [CountryLocalisedId] INT            IDENTITY (1, 1) NOT NULL,
    [Language]           NVARCHAR (MAX) NULL,
    [Name]               NVARCHAR (MAX) NULL,
    [Country_CountryId]  INT            NULL,
    PRIMARY KEY CLUSTERED ([CountryLocalisedId] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);

