ALTER TABLE [dbo].[UaeVisasVersions]
    ADD CONSTRAINT [UaeVisasVersion_UnpublishedBy] FOREIGN KEY ([UnpublishedById]) REFERENCES [dbo].[Members] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

