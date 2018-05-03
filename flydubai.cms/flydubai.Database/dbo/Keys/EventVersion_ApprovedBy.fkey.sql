ALTER TABLE [dbo].[EventVersions]
    ADD CONSTRAINT [EventVersion_ApprovedBy] FOREIGN KEY ([ApprovedById]) REFERENCES [dbo].[Members] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

