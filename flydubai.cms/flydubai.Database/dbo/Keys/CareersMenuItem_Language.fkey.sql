ALTER TABLE [dbo].[CareersMenuItems]
    ADD CONSTRAINT [CareersMenuItem_Language] FOREIGN KEY ([LanguageId]) REFERENCES [dbo].[Languages] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

