ALTER TABLE [dbo].[NewsArticleVersions]
    ADD CONSTRAINT [NewsArticleVersion_ApprovedBy] FOREIGN KEY ([ApprovedById]) REFERENCES [dbo].[Members] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

