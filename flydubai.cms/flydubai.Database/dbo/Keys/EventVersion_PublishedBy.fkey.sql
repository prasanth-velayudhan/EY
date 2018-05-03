ALTER TABLE [dbo].[EventVersions]
    ADD CONSTRAINT [EventVersion_PublishedBy] FOREIGN KEY ([PublishedById]) REFERENCES [dbo].[Members] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

