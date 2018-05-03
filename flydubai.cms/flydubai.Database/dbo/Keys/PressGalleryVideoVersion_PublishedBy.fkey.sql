ALTER TABLE [dbo].[PressGalleryVideoVersions]
    ADD CONSTRAINT [PressGalleryVideoVersion_PublishedBy] FOREIGN KEY ([PublishedById]) REFERENCES [dbo].[Members] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

