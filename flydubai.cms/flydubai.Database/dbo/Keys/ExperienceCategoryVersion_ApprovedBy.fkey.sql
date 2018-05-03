ALTER TABLE [dbo].[ExperienceCategoryVersions]
    ADD CONSTRAINT [ExperienceCategoryVersion_ApprovedBy] FOREIGN KEY ([ApprovedById]) REFERENCES [dbo].[Members] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

