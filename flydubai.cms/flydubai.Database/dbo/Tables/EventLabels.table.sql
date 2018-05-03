CREATE TABLE [dbo].[EventLabels] (
    [EventLabelsId] INT            IDENTITY (1, 1) NOT NULL,
    [ModuleTitle]   NVARCHAR (MAX) NULL,
    [BookButton]    NVARCHAR (MAX) NULL,
    [LanguageId]    INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([EventLabelsId] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);

