ALTER TABLE [dbo].[EventVersions]
    ADD CONSTRAINT [EventVersion_Parent] FOREIGN KEY ([ParentId]) REFERENCES [dbo].[Events] ([EventId]) ON DELETE NO ACTION ON UPDATE NO ACTION;

