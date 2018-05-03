CREATE TABLE [dbo].[NetworkWithUsLabels] (
    [NetworkWithUsLabelsId] INT            IDENTITY (1, 1) NOT NULL,
    [ModuleTitle]           NVARCHAR (MAX) NULL,
    [Facebook]              NVARCHAR (MAX) NULL,
    [Twitter]               NVARCHAR (MAX) NULL,
    [Rss]                   NVARCHAR (MAX) NULL,
    [Flickr]                NVARCHAR (MAX) NULL,
    [YouTube]               NVARCHAR (MAX) NULL,
    [LanguageId]            INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([NetworkWithUsLabelsId] ASC)
);

