ALTER TABLE [dbo].[Faqs]
    ADD CONSTRAINT [Faq_Language] FOREIGN KEY ([LanguageId]) REFERENCES [dbo].[Languages] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

