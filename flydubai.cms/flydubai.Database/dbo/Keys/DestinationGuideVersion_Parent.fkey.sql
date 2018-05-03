ALTER TABLE [dbo].[DestinationGuideVersions]
    ADD CONSTRAINT [DestinationGuideVersion_Parent] 
	FOREIGN KEY ([ParentId]) 
	REFERENCES [dbo].[DestinationGuides] ([DestinationGuideId]);
GO
