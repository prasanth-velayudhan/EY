CREATE TABLE [dbo].[EmergencyContentLabels] (
    [EmergencyContentLabelsId] INT            IDENTITY (1, 1) NOT NULL,
    [OtherUpdatesTitle]        NVARCHAR (MAX) NULL,
    [LatestUpdate]             NVARCHAR (MAX) NULL,
    [LastUpdated]              NVARCHAR (MAX) NULL,
    [ReadMoreLink]             NVARCHAR (MAX) NULL,
    [ViewAllUpdatesLink]       NVARCHAR (MAX) NULL,
    [MoreInformationLink]      NVARCHAR (MAX) NULL,
    [LanguageId]               INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([EmergencyContentLabelsId] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);

