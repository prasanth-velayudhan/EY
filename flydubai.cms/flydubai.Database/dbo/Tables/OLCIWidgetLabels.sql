CREATE TABLE [dbo].[OLCIWidgetLabels] (
    [OLCIWidgetLabelsId] INT            IDENTITY (1, 1) NOT NULL,
    [LanguageId]         INT            NOT NULL,
    [ModuleTitle]        NVARCHAR (MAX) NULL,
    [BookingReference]   NVARCHAR (MAX) NULL,
    [LastName]           NVARCHAR (MAX) NULL,
    [OLCIWidgetGoButton] NVARCHAR (MAX) NOT NULL,
    PRIMARY KEY CLUSTERED ([OLCIWidgetLabelsId] ASC)
);

