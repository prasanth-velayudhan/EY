ALTER TABLE [dbo].[PressGalleryVideoVersions]
    ADD CONSTRAINT [PressGalleryVideoVersion_UnpublishedBy] FOREIGN KEY ([UnpublishedById]) REFERENCES [dbo].[Members] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

