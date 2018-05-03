ALTER TABLE [dbo].[InflightEntertainmentVersions]
    ADD CONSTRAINT [InflightEntertainmentVersion_PublishedBy] FOREIGN KEY ([PublishedById]) REFERENCES [dbo].[Members] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

