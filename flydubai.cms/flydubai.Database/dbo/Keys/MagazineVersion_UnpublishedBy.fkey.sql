ALTER TABLE [dbo].[MagazineVersions]
    ADD CONSTRAINT [MagazineVersion_UnpublishedBy] FOREIGN KEY ([UnpublishedById]) REFERENCES [dbo].[Members] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

