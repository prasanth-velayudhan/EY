ALTER TABLE [dbo].[CareersMenuItemVersions]
    ADD CONSTRAINT [CareersMenuItemVersion_PublishedBy] FOREIGN KEY ([PublishedById]) REFERENCES [dbo].[Members] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

