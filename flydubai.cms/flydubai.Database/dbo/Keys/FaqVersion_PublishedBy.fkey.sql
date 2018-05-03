ALTER TABLE [dbo].[FaqVersions]
    ADD CONSTRAINT [FaqVersion_PublishedBy] FOREIGN KEY ([PublishedById]) REFERENCES [dbo].[Members] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

