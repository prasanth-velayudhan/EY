ALTER TABLE [dbo].[CareersFooterVersions]
    ADD CONSTRAINT [CareersFooterVersion_ApprovedBy] FOREIGN KEY ([ApprovedById]) REFERENCES [dbo].[Members] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

