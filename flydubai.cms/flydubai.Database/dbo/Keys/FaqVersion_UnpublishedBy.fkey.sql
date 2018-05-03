ALTER TABLE [dbo].[FaqVersions]
    ADD CONSTRAINT [FaqVersion_UnpublishedBy] FOREIGN KEY ([UnpublishedById]) REFERENCES [dbo].[Members] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

