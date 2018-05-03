ALTER TABLE [dbo].[FaqVersions]
    ADD CONSTRAINT [FaqVersion_CreatedBy] FOREIGN KEY ([CreatedById]) REFERENCES [dbo].[Members] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

