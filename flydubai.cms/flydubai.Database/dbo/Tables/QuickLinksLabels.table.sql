CREATE TABLE [dbo].[QuickLinksLabels] (
    [QuickLinksLabelsId] INT            IDENTITY (1, 1) NOT NULL,
    [ModuleTitle]        NVARCHAR (MAX) NULL,
    [LanguageId]         INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([QuickLinksLabelsId] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);

