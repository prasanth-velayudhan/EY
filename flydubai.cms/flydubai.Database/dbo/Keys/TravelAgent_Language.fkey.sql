ALTER TABLE [dbo].[TravelAgents]
    ADD CONSTRAINT [TravelAgent_Language] FOREIGN KEY ([LanguageId]) REFERENCES [dbo].[Languages] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

