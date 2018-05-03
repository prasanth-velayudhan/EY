ALTER TABLE [dbo].[SpecialOfferVersions]
    ADD CONSTRAINT [SpecialOfferVersion_PublishedBy] FOREIGN KEY ([PublishedById]) REFERENCES [dbo].[Members] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

