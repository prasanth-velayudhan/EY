CREATE TABLE [dbo].[NewsArticleVersionTag] (
    [NewsArticleVersionId] INT NOT NULL,
    [NewsArticleTagId]     INT NOT NULL,
    PRIMARY KEY CLUSTERED ([NewsArticleVersionId] ASC, [NewsArticleTagId] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);

