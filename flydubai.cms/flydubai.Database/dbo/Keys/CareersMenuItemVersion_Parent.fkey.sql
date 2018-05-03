ALTER TABLE [dbo].[CareersMenuItemVersions]
    ADD CONSTRAINT [CareersMenuItemVersion_Parent] FOREIGN KEY ([ParentId]) REFERENCES [dbo].[CareersMenuItems] ([CareersMenuItemId]) ON DELETE NO ACTION ON UPDATE NO ACTION;

