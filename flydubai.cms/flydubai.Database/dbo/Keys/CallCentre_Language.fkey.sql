ALTER TABLE [dbo].[CallCentres]
    ADD CONSTRAINT [CallCentre_Language] FOREIGN KEY ([LanguageId]) REFERENCES [dbo].[Languages] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

