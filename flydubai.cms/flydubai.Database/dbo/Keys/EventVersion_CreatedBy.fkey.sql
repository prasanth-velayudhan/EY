ALTER TABLE [dbo].[EventVersions]
    ADD CONSTRAINT [EventVersion_CreatedBy] FOREIGN KEY ([CreatedById]) REFERENCES [dbo].[Members] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

