ALTER TABLE [dbo].[PromotionalTeaserVersions]
    ADD CONSTRAINT [PromotionalTeaserVersion_UnpublishedBy] FOREIGN KEY ([UnpublishedById]) REFERENCES [dbo].[Members] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

