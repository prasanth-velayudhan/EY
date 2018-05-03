CREATE TABLE [dbo].[CareersHeaderLabels] (
    [CareersHeaderLabelsId] INT            IDENTITY (1, 1) NOT NULL,
    [PageHeading]           NVARCHAR (MAX) NULL,
    [MenuHome]              NVARCHAR (MAX) NULL,
    [MenuCareers]           NVARCHAR (MAX) NULL,
    [MenuAbout]             NVARCHAR (MAX) NULL,
    [MainSiteLink]          NVARCHAR (MAX) NULL,
    [LanguageId]            INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([CareersHeaderLabelsId] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);

