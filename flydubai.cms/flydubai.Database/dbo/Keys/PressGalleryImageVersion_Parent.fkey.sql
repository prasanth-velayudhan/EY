ALTER TABLE [dbo].[PressGalleryImageVersions]
    ADD CONSTRAINT [PressGalleryImageVersion_Parent] FOREIGN KEY ([ParentId]) REFERENCES [dbo].[PressGalleryImages] ([PressGalleryImageId]) ON DELETE NO ACTION ON UPDATE NO ACTION;

