ALTER TABLE [dbo].[NewsArticleVersions]
    ADD CONSTRAINT [NewsArticleVersion_CreatedBy] FOREIGN KEY ([CreatedById]) REFERENCES [dbo].[Members] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

