ALTER TABLE [dbo].[PressGalleryImageVersions]
    ADD CONSTRAINT [PressGalleryImageVersion_ApprovedBy] FOREIGN KEY ([ApprovedById]) REFERENCES [dbo].[Members] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

