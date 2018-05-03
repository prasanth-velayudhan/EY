ALTER TABLE [dbo].[UaeVisasVersions]
    ADD CONSTRAINT [UaeVisasVersion_PublishedBy] FOREIGN KEY ([PublishedById]) REFERENCES [dbo].[Members] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

