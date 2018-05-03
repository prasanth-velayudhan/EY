ALTER TABLE [dbo].[FooterItemVersions]
    ADD CONSTRAINT [FooterItemVersion_UnpublishedBy] FOREIGN KEY ([UnpublishedById]) REFERENCES [dbo].[Members] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

