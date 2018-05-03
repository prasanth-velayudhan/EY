ALTER TABLE [dbo].[PressGalleryImageVersions]
    ADD CONSTRAINT [PressGalleryImageVersion_PublishedBy] FOREIGN KEY ([PublishedById]) REFERENCES [dbo].[Members] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

