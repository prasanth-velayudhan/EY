ALTER TABLE [dbo].[FooterItemVersions]
    ADD CONSTRAINT [FooterItemVersion_ApprovedBy] FOREIGN KEY ([ApprovedById]) REFERENCES [dbo].[Members] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

