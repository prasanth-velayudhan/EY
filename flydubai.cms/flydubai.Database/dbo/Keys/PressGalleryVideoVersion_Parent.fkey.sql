ALTER TABLE [dbo].[PressGalleryVideoVersions]
    ADD CONSTRAINT [PressGalleryVideoVersion_Parent] FOREIGN KEY ([ParentId]) REFERENCES [dbo].[PressGalleryVideos] ([PressGalleryVideoId]) ON DELETE NO ACTION ON UPDATE NO ACTION;

