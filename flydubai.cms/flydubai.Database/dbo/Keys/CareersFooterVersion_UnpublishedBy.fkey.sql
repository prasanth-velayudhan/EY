ALTER TABLE [dbo].[CareersFooterVersions]
    ADD CONSTRAINT [CareersFooterVersion_UnpublishedBy] FOREIGN KEY ([UnpublishedById]) REFERENCES [dbo].[Members] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

