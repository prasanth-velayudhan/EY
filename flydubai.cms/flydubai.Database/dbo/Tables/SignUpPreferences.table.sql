CREATE TABLE [dbo].[SignUpPreferences] (
    [SignUpPreferencesId]   INT            IDENTITY (1, 1) NOT NULL,
    [Email]                 NVARCHAR (MAX) NULL,
    [Sms]                   NVARCHAR (MAX) NULL,
    [Title]                 NVARCHAR (MAX) NULL,
    [FirstName]             NVARCHAR (MAX) NULL,
    [LastName]              NVARCHAR (MAX) NULL,
    [CountryId]             INT            NULL,
    [PreferredLanguageCode] NVARCHAR (MAX) NULL,
    [SpecialOffers]         BIT            NULL,
    [MonthlyNews]           BIT            NULL,
    [PartnerPromotions]     BIT            NULL,
    [OffersDestination1]    NVARCHAR (MAX) NULL,
    [OffersDestination2]    NVARCHAR (MAX) NULL,
    [OffersDestination3]    NVARCHAR (MAX) NULL,
    [CreatedDate]           DATETIME       NULL,
    [UpdatedDate]           DATETIME       NULL,
    PRIMARY KEY CLUSTERED ([SignUpPreferencesId] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);

