ALTER TABLE [dbo].[PromotionalTeasers]
    ADD CONSTRAINT [PromotionalTeaser_Language] FOREIGN KEY ([LanguageId]) REFERENCES [dbo].[Languages] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

