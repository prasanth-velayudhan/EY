ALTER TABLE [dbo].[FooterItemVersions]
    ADD CONSTRAINT [FooterItemVersion_CreatedBy] FOREIGN KEY ([CreatedById]) REFERENCES [dbo].[Members] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

