ALTER TABLE [dbo].[MagazineVersions]
    ADD CONSTRAINT [MagazineVersion_CreatedBy] FOREIGN KEY ([CreatedById]) REFERENCES [dbo].[Members] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

