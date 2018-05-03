ALTER TABLE [dbo].[InflightEntertainmentVersions]
    ADD CONSTRAINT [InflightEntertainmentVersion_ApprovedBy] FOREIGN KEY ([ApprovedById]) REFERENCES [dbo].[Members] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

