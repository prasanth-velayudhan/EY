ALTER TABLE [dbo].[NewsArticleVersionTag]
    ADD CONSTRAINT [NewsArticleVersion_Tags_Target] FOREIGN KEY ([NewsArticleTagId]) REFERENCES [dbo].[NewsArticleTags] ([NewsArticleTagId]) ON DELETE CASCADE ON UPDATE NO ACTION;

