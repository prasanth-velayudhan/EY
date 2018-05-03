ALTER TABLE [dbo].[DestinationGuideVersionCategory] ADD CONSTRAINT [DestinationGuideVersion_DestinationCategories_Target]
	FOREIGN KEY ([DestinationCategoryId]) REFERENCES [dbo].[DestinationCategories] ([DestinationCategoryId]) ON DELETE CASCADE;
