ALTER TABLE [dbo].[SpecialOfferVersions]
    ADD CONSTRAINT [SpecialOfferVersion_UnpublishedBy] FOREIGN KEY ([UnpublishedById]) REFERENCES [dbo].[Members] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

