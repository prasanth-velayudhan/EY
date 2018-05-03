ALTER TABLE [dbo].[PressGalleryImageVersions]
    ADD CONSTRAINT [PressGalleryImageVersion_CreatedBy] FOREIGN KEY ([CreatedById]) REFERENCES [dbo].[Members] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

