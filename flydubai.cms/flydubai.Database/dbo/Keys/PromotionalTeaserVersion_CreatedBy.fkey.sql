ALTER TABLE [dbo].[PromotionalTeaserVersions]
    ADD CONSTRAINT [PromotionalTeaserVersion_CreatedBy] FOREIGN KEY ([CreatedById]) REFERENCES [dbo].[Members] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

