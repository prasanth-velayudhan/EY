ALTER TABLE [dbo].[DestinationGuideVersions] ADD CONSTRAINT [AirportInformation_DestinationGuideVersions]
	FOREIGN KEY ([AirportInformation_AirportInformationId]) REFERENCES [dbo].[AirportInformations] ([AirportInformationId])
GO

ALTER TABLE [dbo].[DestinationGuideVersions] CHECK CONSTRAINT [AirportInformation_DestinationGuideVersions]
GO
