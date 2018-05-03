CREATE TABLE [dbo].[WhereWeFlyLabels] (
    [WhereWeFlyLabelsId]   INT            IDENTITY (1, 1) NOT NULL,
    [ModuleTitle]          NVARCHAR (MAX) NULL,
    [FindDestinationsLink] NVARCHAR (MAX) NULL,
    [LanguageId]           INT            NOT NULL,
    [WeFlyGoButton]        NVARCHAR (MAX) NOT NULL,
    PRIMARY KEY CLUSTERED ([WhereWeFlyLabelsId] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);

