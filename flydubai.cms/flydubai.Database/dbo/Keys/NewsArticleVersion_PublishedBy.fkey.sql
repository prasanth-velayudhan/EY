ALTER TABLE [dbo].[NewsArticleVersions]
    ADD CONSTRAINT [NewsArticleVersion_PublishedBy] FOREIGN KEY ([PublishedById]) REFERENCES [dbo].[Members] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

