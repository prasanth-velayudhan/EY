ALTER TABLE [dbo].[TravelAgentVersions]
    ADD CONSTRAINT [TravelAgentVersion_City] FOREIGN KEY ([CityId]) REFERENCES [dbo].[Cities] ([CityId]) ON DELETE NO ACTION ON UPDATE NO ACTION;

