ALTER TABLE [dbo].[PromotionalTeaserVersions]
    ADD CONSTRAINT [PromotionalTeaserVersion_ApprovedBy] FOREIGN KEY ([ApprovedById]) REFERENCES [dbo].[Members] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

