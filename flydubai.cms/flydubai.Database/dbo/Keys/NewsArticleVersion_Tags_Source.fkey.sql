ALTER TABLE [dbo].[NewsArticleVersionTag]
    ADD CONSTRAINT [NewsArticleVersion_Tags_Source] FOREIGN KEY ([NewsArticleVersionId]) REFERENCES [dbo].[NewsArticleVersions] ([NewsArticleVersionId]) ON DELETE CASCADE ON UPDATE NO ACTION;

