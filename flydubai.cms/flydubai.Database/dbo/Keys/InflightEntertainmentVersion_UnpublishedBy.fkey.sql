ALTER TABLE [dbo].[InflightEntertainmentVersions]
    ADD CONSTRAINT [InflightEntertainmentVersion_UnpublishedBy] FOREIGN KEY ([UnpublishedById]) REFERENCES [dbo].[Members] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

