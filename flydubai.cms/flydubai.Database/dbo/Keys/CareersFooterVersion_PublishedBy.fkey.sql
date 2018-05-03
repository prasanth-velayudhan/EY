ALTER TABLE [dbo].[CareersFooterVersions]
    ADD CONSTRAINT [CareersFooterVersion_PublishedBy] FOREIGN KEY ([PublishedById]) REFERENCES [dbo].[Members] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

