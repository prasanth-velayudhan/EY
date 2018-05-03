ALTER TABLE [dbo].[PromotionalTeaserVersions]
    ADD CONSTRAINT [PromotionalTeaserVersion_Parent] FOREIGN KEY ([ParentId]) REFERENCES [dbo].[PromotionalTeasers] ([PromotionalTeaserId]) ON DELETE NO ACTION ON UPDATE NO ACTION;

