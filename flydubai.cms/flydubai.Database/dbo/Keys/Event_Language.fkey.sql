ALTER TABLE [dbo].[Events]
    ADD CONSTRAINT [Event_Language] FOREIGN KEY ([LanguageId]) REFERENCES [dbo].[Languages] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

