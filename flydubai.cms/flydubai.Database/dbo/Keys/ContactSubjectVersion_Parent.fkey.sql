ALTER TABLE [dbo].[ContactSubjectVersions]
    ADD CONSTRAINT [ContactSubjectVersion_Parent] FOREIGN KEY ([ParentId]) REFERENCES [dbo].[ContactSubjects] ([ContactSubjectId]) ON DELETE NO ACTION ON UPDATE NO ACTION;

