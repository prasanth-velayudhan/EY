ALTER TABLE [dbo].[DestinationGuides]
    ADD CONSTRAINT [DestinationGuide_Language] FOREIGN KEY ([LanguageId]) REFERENCES [dbo].[Languages] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

