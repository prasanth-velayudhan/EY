ALTER TABLE [dbo].[DestinationGuideVersions]
    ADD CONSTRAINT [DestinationGuideVersion_UnpublishedBy] 
	FOREIGN KEY ([UnpublishedById]) 
	REFERENCES [dbo].[Members] ([Id]);
GO
