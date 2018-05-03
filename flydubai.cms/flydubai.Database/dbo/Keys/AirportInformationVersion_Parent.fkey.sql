ALTER TABLE [dbo].[AirportInformationVersions]  WITH CHECK ADD  CONSTRAINT [AirportInformationVersion_Parent] FOREIGN KEY([ParentId])
REFERENCES [dbo].[AirportInformations] ([AirportInformationId])
GO

ALTER TABLE [dbo].[AirportInformationVersions] CHECK CONSTRAINT [AirportInformationVersion_Parent]
GO

