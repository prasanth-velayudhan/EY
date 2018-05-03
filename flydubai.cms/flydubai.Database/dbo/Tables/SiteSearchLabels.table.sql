CREATE TABLE [dbo].[SiteSearchLabels] (
    [SiteSearchLabelsId]     INT            IDENTITY (1, 1) NOT NULL,
    [SearchResultsLabel]     NVARCHAR (MAX) NULL,
    [AllResultsLabel]        NVARCHAR (MAX) NULL,
    [ResultsFoundLabel]      NVARCHAR (MAX) NULL,
    [SearchPaging]           NVARCHAR (MAX) NULL,
    [PagingPrevious]         NVARCHAR (MAX) NULL,
    [PagingNext]             NVARCHAR (MAX) NULL,
    [NoResultsTitle]         NVARCHAR (MAX) NULL,
    [NoResultsCategoryTitle] NVARCHAR (MAX) NULL,
    [NoResultsCategory]      NVARCHAR (MAX) NULL,
    [SearchAgain]            NVARCHAR (MAX) NULL,
    [Suggestions]            NVARCHAR (MAX) NULL,
    [CategoriesTitle]        NVARCHAR (MAX) NULL,
    [CategoriesAllResults]   NVARCHAR (MAX) NULL,
    [LanguageId]             INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([SiteSearchLabelsId] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);

