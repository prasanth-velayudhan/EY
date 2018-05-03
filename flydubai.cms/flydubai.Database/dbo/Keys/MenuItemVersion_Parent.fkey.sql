ALTER TABLE [dbo].[MenuItemVersions]
    ADD CONSTRAINT [MenuItemVersion_Parent] FOREIGN KEY ([ParentId]) REFERENCES [dbo].[MenuItems] ([MenuItemId]) ON DELETE NO ACTION ON UPDATE NO ACTION;

