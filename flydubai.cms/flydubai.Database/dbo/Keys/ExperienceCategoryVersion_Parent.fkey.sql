ALTER TABLE [dbo].[ExperienceCategoryVersions]
    ADD CONSTRAINT [ExperienceCategoryVersion_Parent] FOREIGN KEY ([ParentId]) REFERENCES [dbo].[ExperienceCategories] ([ExperienceCategoryId]) ON DELETE NO ACTION ON UPDATE NO ACTION;

