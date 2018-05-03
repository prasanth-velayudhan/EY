CREATE TABLE [dbo].[GlobalPRContactLabels] (
    [GlobalPRContactLabelsId]      INT            IDENTITY (1, 1) NOT NULL,
    [ListSectionHeader]            NVARCHAR (MAX) NULL,
    [SearchSectionHeader]          NVARCHAR (MAX) NULL,
    [SearchCountryLabelText]       NVARCHAR (MAX) NULL,
    [SearchButtonLabel]            NVARCHAR (MAX) NULL,
    [CountryDropdownDefaultOption] NVARCHAR (MAX) NULL,
    [LocationColumnHeader]         NVARCHAR (MAX) NULL,
    [EmailColumnHeader]            NVARCHAR (MAX) NULL,
    [TelephoneColumnHeader]        NVARCHAR (MAX) NULL,
    [LanguageId]                   INT            NOT NULL,
    [ContactName]                  NVARCHAR (MAX) NOT NULL,
    PRIMARY KEY CLUSTERED ([GlobalPRContactLabelsId] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);

