ALTER TABLE [dbo].[MenuItemVersions]
    ADD CONSTRAINT [MenuItemVersion_UnpublishedBy] FOREIGN KEY ([UnpublishedById]) REFERENCES [dbo].[Members] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

