ALTER TABLE [dbo].[InflightEntertainmentVersions]
    ADD CONSTRAINT [InflightEntertainmentVersion_CreatedBy] FOREIGN KEY ([CreatedById]) REFERENCES [dbo].[Members] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

