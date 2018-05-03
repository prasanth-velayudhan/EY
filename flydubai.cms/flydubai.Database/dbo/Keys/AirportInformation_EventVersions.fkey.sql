ALTER TABLE [dbo].[EventVersions]  WITH CHECK ADD  CONSTRAINT [AirportInformation_EventVersions] FOREIGN KEY([AirportInformation_AirportInformationId])
REFERENCES [dbo].[AirportInformations] ([AirportInformationId])
GO

ALTER TABLE [dbo].[EventVersions] CHECK CONSTRAINT [AirportInformation_EventVersions]
GO

