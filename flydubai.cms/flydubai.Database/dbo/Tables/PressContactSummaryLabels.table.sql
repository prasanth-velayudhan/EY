CREATE TABLE [dbo].[PressContactSummaryLabels] (
    [PressContactSummaryLabelsId]                 INT            IDENTITY (1, 1) NOT NULL,
    [PressContactSummaryMainTitle]                NVARCHAR (MAX) NULL,
    [PressContactSummaryText]                     NVARCHAR (MAX) NULL,
    [PressContactSummaryCallLabel]                NVARCHAR (MAX) NULL,
    [PressContactSummaryEmailLabel]               NVARCHAR (MAX) NULL,
    [PressContactSummaryOfficeHoursLabel]         NVARCHAR (MAX) NULL,
    [PressContactSummaryGlobalPRContactsLinkText] NVARCHAR (MAX) NULL,
    [LanguageId]                                  INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([PressContactSummaryLabelsId] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);

