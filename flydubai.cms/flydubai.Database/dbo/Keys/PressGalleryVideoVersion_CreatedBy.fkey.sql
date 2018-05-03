ALTER TABLE [dbo].[PressGalleryVideoVersions]
    ADD CONSTRAINT [PressGalleryVideoVersion_CreatedBy] FOREIGN KEY ([CreatedById]) REFERENCES [dbo].[Members] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

