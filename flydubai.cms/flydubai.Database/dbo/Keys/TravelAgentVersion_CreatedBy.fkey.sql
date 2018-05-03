ALTER TABLE [dbo].[TravelAgentVersions]
    ADD CONSTRAINT [TravelAgentVersion_CreatedBy] FOREIGN KEY ([CreatedById]) REFERENCES [dbo].[Members] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

