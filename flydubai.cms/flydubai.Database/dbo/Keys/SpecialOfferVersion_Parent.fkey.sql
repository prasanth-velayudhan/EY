ALTER TABLE [dbo].[SpecialOfferVersions]
    ADD CONSTRAINT [SpecialOfferVersion_Parent] FOREIGN KEY ([ParentId]) REFERENCES [dbo].[SpecialOffers] ([SpecialOfferId]) ON DELETE NO ACTION ON UPDATE NO ACTION;

