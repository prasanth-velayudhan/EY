ALTER TABLE [dbo].[DestinationGuideVersionCategory] ADD CONSTRAINT [DestinationGuideVersion_DestinationCategories_Source]
	FOREIGN KEY ([DestinationGuideVersionId]) REFERENCES [dbo].[DestinationGuideVersions] ([DestinationGuideVersionId]) ON DELETE CASCADE;
