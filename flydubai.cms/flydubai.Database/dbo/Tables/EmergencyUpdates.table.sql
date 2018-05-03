CREATE TABLE [dbo].[EmergencyUpdates] (
    [EmergencyUpdateId] INT            IDENTITY (1, 1) NOT NULL,
    [UrlIdentifier]     NVARCHAR (MAX) NULL,
    [CmsName]           NVARCHAR (MAX) NULL,
    [EmergencyId]       INT            NOT NULL,
    [UpdateDate]        DATETIME2 (7)  NOT NULL,
    [Time]              NVARCHAR (MAX) NULL,
    [Title]             NVARCHAR (MAX) NULL,
    [ShortSummary]      NVARCHAR (MAX) NULL,
    [SummaryHtml]       NVARCHAR (MAX) NULL,
    [BodyHtml]          NVARCHAR (MAX) NULL,
    [ThumbnailImage]    INT            NULL,
    [Image]             INT            NULL,
    [VideoTitle]        NVARCHAR (MAX) NULL,
    [VideoUrl]          NVARCHAR (MAX) NULL,
    [CreatedDate]       DATETIME2 (7)  NOT NULL,
    [IsArchived]        BIT            NOT NULL,
    PRIMARY KEY CLUSTERED ([EmergencyUpdateId] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);

