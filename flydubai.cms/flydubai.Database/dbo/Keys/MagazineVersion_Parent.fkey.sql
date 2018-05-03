ALTER TABLE [dbo].[MagazineVersions]
    ADD CONSTRAINT [MagazineVersion_Parent] FOREIGN KEY ([ParentId]) REFERENCES [dbo].[Magazines] ([MagazineId]) ON DELETE NO ACTION ON UPDATE NO ACTION;

