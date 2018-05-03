ALTER TABLE [dbo].[DestinationGuideVersions]
    ADD CONSTRAINT [DestinationGuideVersion_CreatedBy] 
	FOREIGN KEY ([CreatedById]) 
	REFERENCES [dbo].[Members] ([Id]);
GO
