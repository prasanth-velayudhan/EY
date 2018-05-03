ALTER TABLE [dbo].[PromotionalTeaserVersions]
    ADD CONSTRAINT [PromotionalTeaserVersion_PublishedBy] FOREIGN KEY ([PublishedById]) REFERENCES [dbo].[Members] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

