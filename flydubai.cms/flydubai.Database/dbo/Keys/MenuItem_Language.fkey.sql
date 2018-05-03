ALTER TABLE [dbo].[MenuItems]
    ADD CONSTRAINT [MenuItem_Language] FOREIGN KEY ([LanguageId]) REFERENCES [dbo].[Languages] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

