ALTER TABLE [dbo].[ExperienceCategoryVersions]
    ADD CONSTRAINT [ExperienceCategoryVersion_CreatedBy] FOREIGN KEY ([CreatedById]) REFERENCES [dbo].[Members] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

