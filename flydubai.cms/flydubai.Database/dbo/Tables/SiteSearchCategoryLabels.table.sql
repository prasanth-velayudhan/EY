CREATE TABLE [dbo].[SiteSearchCategoryLabels] (
    [SiteSearchCategoryLabelsId] INT            IDENTITY (1, 1) NOT NULL,
    [Plan]                       NVARCHAR (MAX) NULL,
    [Travel]                     NVARCHAR (MAX) NULL,
    [SpecialOffers]              NVARCHAR (MAX) NULL,
    [AboutUs]                    NVARCHAR (MAX) NULL,
    [News]                       NVARCHAR (MAX) NULL,
    [ContactUs]                  NVARCHAR (MAX) NULL,
    [LanguageId]                 INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([SiteSearchCategoryLabelsId] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);

