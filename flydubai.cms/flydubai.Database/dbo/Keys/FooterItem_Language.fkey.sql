ALTER TABLE [dbo].[FooterItems]
    ADD CONSTRAINT [FooterItem_Language] FOREIGN KEY ([LanguageId]) REFERENCES [dbo].[Languages] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

