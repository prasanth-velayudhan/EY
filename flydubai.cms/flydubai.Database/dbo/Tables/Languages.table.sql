CREATE TABLE [dbo].[Languages] (
    [Id]                    INT            IDENTITY (1, 1) NOT NULL,
    [Name]                  NVARCHAR (MAX) NULL,
    [Code]                  NVARCHAR (MAX) NULL,
    [IsLive]                BIT            NOT NULL,
    [IsRightToLeft]         BIT            NOT NULL,
    [DefaultLocale]         NVARCHAR (MAX) NULL,
    [LocalisedLanguageName] NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);



