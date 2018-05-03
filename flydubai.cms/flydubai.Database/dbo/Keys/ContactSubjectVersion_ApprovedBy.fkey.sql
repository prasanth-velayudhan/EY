ALTER TABLE [dbo].[ContactSubjectVersions]
    ADD CONSTRAINT [ContactSubjectVersion_ApprovedBy] FOREIGN KEY ([ApprovedById]) REFERENCES [dbo].[Members] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

