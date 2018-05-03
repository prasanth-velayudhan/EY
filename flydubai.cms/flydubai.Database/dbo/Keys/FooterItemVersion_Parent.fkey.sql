ALTER TABLE [dbo].[FooterItemVersions]
    ADD CONSTRAINT [FooterItemVersion_Parent] FOREIGN KEY ([ParentId]) REFERENCES [dbo].[FooterItems] ([FooterItemId]) ON DELETE NO ACTION ON UPDATE NO ACTION;

