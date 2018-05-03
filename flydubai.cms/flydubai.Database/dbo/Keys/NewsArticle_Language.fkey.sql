ALTER TABLE [dbo].[NewsArticles]
    ADD CONSTRAINT [NewsArticle_Language] FOREIGN KEY ([LanguageId]) REFERENCES [dbo].[Languages] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

