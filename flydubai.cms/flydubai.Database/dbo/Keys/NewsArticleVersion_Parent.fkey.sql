ALTER TABLE [dbo].[NewsArticleVersions]
    ADD CONSTRAINT [NewsArticleVersion_Parent] FOREIGN KEY ([ParentId]) REFERENCES [dbo].[NewsArticles] ([NewsArticleId]) ON DELETE NO ACTION ON UPDATE NO ACTION;

