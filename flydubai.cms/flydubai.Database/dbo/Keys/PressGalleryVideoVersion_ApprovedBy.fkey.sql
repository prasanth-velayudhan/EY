ALTER TABLE [dbo].[PressGalleryVideoVersions]
    ADD CONSTRAINT [PressGalleryVideoVersion_ApprovedBy] FOREIGN KEY ([ApprovedById]) REFERENCES [dbo].[Members] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

