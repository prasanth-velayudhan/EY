CREATE TABLE [dbo].[UaeVisasLabels] (
    [UaeVisasLabelsId] INT            IDENTITY (1, 1) NOT NULL,
    [ModuleTitle]      NVARCHAR (MAX) NULL,
    [ResidentStatus]   NVARCHAR (MAX) NULL,
    [Select]           NVARCHAR (MAX) NULL,
    [DownloadButton]   NVARCHAR (MAX) NULL,
    [LanguageId]       INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([UaeVisasLabelsId] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);

