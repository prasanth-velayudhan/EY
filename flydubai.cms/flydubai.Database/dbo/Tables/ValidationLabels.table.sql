CREATE TABLE [dbo].[ValidationLabels] (
    [ValidationLabelsId]             INT            IDENTITY (1, 1) NOT NULL,
    [DefaultRequired]                NVARCHAR (MAX) NULL,
    [DefaultLowerCaseAlphaNumeric]   NVARCHAR (MAX) NULL,
    [InvalidFlightRoute]             NVARCHAR (MAX) NULL,
    [InvalidFlightNumber]            NVARCHAR (MAX) NULL,
    [InvalidPhoneNumber]             NVARCHAR (MAX) NULL,
    [InvalidEmail]                   NVARCHAR (MAX) NULL,
    [InvalidValue]                   NVARCHAR (MAX) NULL,
    [AtleastOneDestinationRequired]  NVARCHAR (MAX) NULL,
    [AtleastOneSubscriptionRequired] NVARCHAR (MAX) NULL,
    [LanguageId]                     INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([ValidationLabelsId] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);

