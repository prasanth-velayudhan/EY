ALTER TABLE [dbo].[AirportInformationVersions]  WITH CHECK ADD  CONSTRAINT [AirportInformationVersion_CreatedBy] FOREIGN KEY([CreatedById])
REFERENCES [dbo].[Members] ([Id])
GO

ALTER TABLE [dbo].[AirportInformationVersions] CHECK CONSTRAINT [AirportInformationVersion_CreatedBy]
GO

