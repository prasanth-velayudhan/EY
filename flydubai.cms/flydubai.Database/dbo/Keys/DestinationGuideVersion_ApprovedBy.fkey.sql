ALTER TABLE [dbo].[DestinationGuideVersions]
    ADD CONSTRAINT [DestinationGuideVersion_ApprovedBy] 
	FOREIGN KEY ([ApprovedById]) 
	REFERENCES [dbo].[Members] ([Id]);
GO
