ALTER TABLE [dbo].[CareersFooterVersions]
    ADD CONSTRAINT [CareersFooterVersion_CreatedBy] FOREIGN KEY ([CreatedById]) REFERENCES [dbo].[Members] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

