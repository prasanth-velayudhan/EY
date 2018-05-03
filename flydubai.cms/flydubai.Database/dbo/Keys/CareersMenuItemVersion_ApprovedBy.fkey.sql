ALTER TABLE [dbo].[CareersMenuItemVersions]
    ADD CONSTRAINT [CareersMenuItemVersion_ApprovedBy] FOREIGN KEY ([ApprovedById]) REFERENCES [dbo].[Members] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

