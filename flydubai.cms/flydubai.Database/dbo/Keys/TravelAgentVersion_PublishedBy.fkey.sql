ALTER TABLE [dbo].[TravelAgentVersions]
    ADD CONSTRAINT [TravelAgentVersion_PublishedBy] FOREIGN KEY ([PublishedById]) REFERENCES [dbo].[Members] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

