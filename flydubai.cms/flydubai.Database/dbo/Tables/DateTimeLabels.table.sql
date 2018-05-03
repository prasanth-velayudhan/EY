CREATE TABLE [dbo].[DateTimeLabels] (
    [DateTimeLabelsId] INT            IDENTITY (1, 1) NOT NULL,
    [Yesterday]        NVARCHAR (MAX) NULL,
    [Today]            NVARCHAR (MAX) NULL,
    [Tomorrow]         NVARCHAR (MAX) NULL,
    [January]          NVARCHAR (MAX) NULL,
    [February]         NVARCHAR (MAX) NULL,
    [March]            NVARCHAR (MAX) NULL,
    [April]            NVARCHAR (MAX) NULL,
    [May]              NVARCHAR (MAX) NULL,
    [June]             NVARCHAR (MAX) NULL,
    [July]             NVARCHAR (MAX) NULL,
    [August]           NVARCHAR (MAX) NULL,
    [September]        NVARCHAR (MAX) NULL,
    [October]          NVARCHAR (MAX) NULL,
    [November]         NVARCHAR (MAX) NULL,
    [December]         NVARCHAR (MAX) NULL,
    [LanguageId]       INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([DateTimeLabelsId] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);

