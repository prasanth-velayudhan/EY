ALTER TABLE [dbo].[MagazineVersions]
    ADD CONSTRAINT [MagazineVersion_ApprovedBy] FOREIGN KEY ([ApprovedById]) REFERENCES [dbo].[Members] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

