ALTER TABLE [dbo].[ContactSubjectVersions]
    ADD CONSTRAINT [ContactSubjectVersion_CreatedBy] FOREIGN KEY ([CreatedById]) REFERENCES [dbo].[Members] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

