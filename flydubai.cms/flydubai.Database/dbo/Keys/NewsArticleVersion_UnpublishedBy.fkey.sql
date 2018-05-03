ALTER TABLE [dbo].[NewsArticleVersions]
    ADD CONSTRAINT [NewsArticleVersion_UnpublishedBy] FOREIGN KEY ([UnpublishedById]) REFERENCES [dbo].[Members] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

