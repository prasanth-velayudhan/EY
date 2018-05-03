ALTER TABLE [dbo].[ContactSubjectVersions]
    ADD CONSTRAINT [ContactSubjectVersion_PublishedBy] FOREIGN KEY ([PublishedById]) REFERENCES [dbo].[Members] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

