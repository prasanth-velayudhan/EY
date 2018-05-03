CREATE TABLE [dbo].[Contingencies] (
    [ContingencyId]          INT            IDENTITY (1, 1) NOT NULL,
    [UrlIdentifier]          NVARCHAR (MAX) NULL,
    [CmsName]                NVARCHAR (MAX) NULL,
    [LanguageId]             INT            NOT NULL,
    [IconCssClass]           NVARCHAR (MAX) NULL,
    [Date]                   DATETIME2 (7)  NULL,
    [DisplayDate]            BIT            NOT NULL,
    [Time]                   NVARCHAR (MAX) NULL,
    [Title]                  NVARCHAR (MAX) NULL,
    [StatementHtml]          NVARCHAR (MAX) NULL,
    [DisplayMoreInformation] BIT            NOT NULL,
    [CreatedDate]            DATETIME2 (7)  NOT NULL,
    [IsArchived]             BIT            NOT NULL,
    PRIMARY KEY CLUSTERED ([ContingencyId] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);

