CREATE TABLE [dbo].[CustomPages] (
    [CustomPageId]     INT            IDENTITY (1, 1) NOT NULL,
    [MasterPage]       NVARCHAR (MAX) NULL,
    [Template]         NVARCHAR (MAX) NULL,
    [Url]              NVARCHAR (MAX) NULL,
    [WebsiteSection]   NVARCHAR (MAX) NULL,
    [SecondarySection] NVARCHAR (MAX) NULL,
    [STATUS]           NVARCHAR (MAX) NULL,
    [IsRedirect]       BIT            DEFAULT ((0)) NOT NULL,
    [RedirectUrl]      NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([CustomPageId] ASC)
);





