ALTER TABLE [dbo].[CareersMenuItemVersions]
    ADD CONSTRAINT [CareersMenuItemVersion_CreatedBy] FOREIGN KEY ([CreatedById]) REFERENCES [dbo].[Members] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

