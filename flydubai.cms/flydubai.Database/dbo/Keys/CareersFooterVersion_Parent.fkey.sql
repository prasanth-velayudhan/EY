ALTER TABLE [dbo].[CareersFooterVersions]
    ADD CONSTRAINT [CareersFooterVersion_Parent] FOREIGN KEY ([ParentId]) REFERENCES [dbo].[CareersFooters] ([CareersFooterId]) ON DELETE NO ACTION ON UPDATE NO ACTION;

