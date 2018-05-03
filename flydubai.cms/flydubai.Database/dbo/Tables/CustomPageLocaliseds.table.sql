CREATE TABLE [dbo].[CustomPageLocaliseds] (
    [CustomPageId] INT            NOT NULL,
    [PageName]     NVARCHAR (MAX) NULL,
    [LanguageId]   INT            NOT NULL,
    [Status]       NVARCHAR (MAX) NULL,
    [IsRedirect]   BIT            DEFAULT ((0)) NOT NULL,
    [RedirectUrl]  NVARCHAR (MAX) NULL
);



