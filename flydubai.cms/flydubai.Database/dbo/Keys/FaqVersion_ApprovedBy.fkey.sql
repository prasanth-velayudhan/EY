ALTER TABLE [dbo].[FaqVersions]
    ADD CONSTRAINT [FaqVersion_ApprovedBy] FOREIGN KEY ([ApprovedById]) REFERENCES [dbo].[Members] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

