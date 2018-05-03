ALTER TABLE [dbo].[TravelAgentVersions]
    ADD CONSTRAINT [TravelAgentVersion_Parent] FOREIGN KEY ([ParentId]) REFERENCES [dbo].[TravelAgents] ([TravelAgentId]) ON DELETE NO ACTION ON UPDATE NO ACTION;

