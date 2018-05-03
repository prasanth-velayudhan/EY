ALTER TABLE [dbo].[Media]
    ADD CONSTRAINT [Media_MediaCategory] FOREIGN KEY ([MediaCategoryId]) REFERENCES [dbo].[MediaCategories] ([MediaCategoryId]) ON DELETE NO ACTION ON UPDATE NO ACTION;

