ALTER TABLE [dbo].[MagazineVersions]
    ADD CONSTRAINT [MagazineVersion_PublishedBy] FOREIGN KEY ([PublishedById]) REFERENCES [dbo].[Members] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

