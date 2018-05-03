CREATE TABLE [dbo].[CustomErrorPages] (
    [CustomErrorPageId]   INT            IDENTITY (1, 1) NOT NULL,
    [HttpStatusCode]      INT            NOT NULL,
    [PageTitle]           NVARCHAR (MAX) NOT NULL,
    [PageHeading]         NVARCHAR (MAX) NOT NULL,
    [UserMessageHtml]     NVARCHAR (MAX) NOT NULL,
    [LinkToExistingPages] BIT            NOT NULL,
    [LastUpdated]         DATETIME       NOT NULL,
    [NavigationTitleText] NVARCHAR (MAX) NULL,
    [LanguageId]          INT            CONSTRAINT [DF_CustomErrorPages_LanguageId] DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([CustomErrorPageId] ASC)
);



