ALTER TABLE [dbo].[SpecialOfferVersions]
    ADD CONSTRAINT [SpecialOfferVersion_ApprovedBy] FOREIGN KEY ([ApprovedById]) REFERENCES [dbo].[Members] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

