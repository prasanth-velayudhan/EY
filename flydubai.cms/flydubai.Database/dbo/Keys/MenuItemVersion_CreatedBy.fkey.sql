ALTER TABLE [dbo].[MenuItemVersions]
    ADD CONSTRAINT [MenuItemVersion_CreatedBy] FOREIGN KEY ([CreatedById]) REFERENCES [dbo].[Members] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

