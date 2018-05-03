CREATE TABLE [dbo].[EmergencyHeaderLabels] (
    [EmergencyHeaderLabelsId] INT            IDENTITY (1, 1) NOT NULL,
    [MainSiteLink]            NVARCHAR (MAX) NULL,
    [MenuHome]                NVARCHAR (MAX) NULL,
    [MenuLatestUpdates]       NVARCHAR (MAX) NULL,
    [MenuPressCentre]         NVARCHAR (MAX) NULL,
    [LanguageId]              INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([EmergencyHeaderLabelsId] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);

