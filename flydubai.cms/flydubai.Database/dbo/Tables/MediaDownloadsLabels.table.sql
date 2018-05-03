CREATE TABLE [dbo].[MediaDownloadsLabels] (
    [MediaDownloadsLabelsId] INT            IDENTITY (1, 1) NOT NULL,
    [Title]                  NVARCHAR (MAX) NULL,
    [MediaPack]              NVARCHAR (MAX) NULL,
    [OfficialStatement]      NVARCHAR (MAX) NULL,
    [LanguageId]             INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([MediaDownloadsLabelsId] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);

