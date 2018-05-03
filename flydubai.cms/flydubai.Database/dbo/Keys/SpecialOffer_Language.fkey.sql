ALTER TABLE [dbo].[SpecialOffers]
    ADD CONSTRAINT [SpecialOffer_Language] FOREIGN KEY ([LanguageId]) REFERENCES [dbo].[Languages] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

