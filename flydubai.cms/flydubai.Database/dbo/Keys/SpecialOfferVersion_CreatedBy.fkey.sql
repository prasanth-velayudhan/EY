ALTER TABLE [dbo].[SpecialOfferVersions]
    ADD CONSTRAINT [SpecialOfferVersion_CreatedBy] FOREIGN KEY ([CreatedById]) REFERENCES [dbo].[Members] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

