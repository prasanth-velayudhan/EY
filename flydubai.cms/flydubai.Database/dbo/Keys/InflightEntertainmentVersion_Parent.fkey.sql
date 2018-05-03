ALTER TABLE [dbo].[InflightEntertainmentVersions]
    ADD CONSTRAINT [InflightEntertainmentVersion_Parent] FOREIGN KEY ([ParentId]) REFERENCES [dbo].[InflightEntertainments] ([InflightEntertainmentId]) ON DELETE NO ACTION ON UPDATE NO ACTION;

