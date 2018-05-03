ALTER TABLE [dbo].[PressGalleryImageVersions]
    ADD CONSTRAINT [PressGalleryImageVersion_UnpublishedBy] FOREIGN KEY ([UnpublishedById]) REFERENCES [dbo].[Members] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

