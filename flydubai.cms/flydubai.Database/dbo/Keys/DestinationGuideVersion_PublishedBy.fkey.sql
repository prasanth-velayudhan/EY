ALTER TABLE [dbo].[DestinationGuideVersions]
    ADD CONSTRAINT [DestinationGuideVersion_PublishedBy] 
	FOREIGN KEY ([PublishedById]) 
	REFERENCES [dbo].[Members] ([Id]);
GO
