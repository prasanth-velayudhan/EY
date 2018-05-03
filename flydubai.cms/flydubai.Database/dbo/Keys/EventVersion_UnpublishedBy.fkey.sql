ALTER TABLE [dbo].[EventVersions]
    ADD CONSTRAINT [EventVersion_UnpublishedBy] FOREIGN KEY ([UnpublishedById]) REFERENCES [dbo].[Members] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

