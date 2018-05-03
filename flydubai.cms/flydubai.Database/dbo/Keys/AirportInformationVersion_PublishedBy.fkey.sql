ALTER TABLE [dbo].[AirportInformationVersions]  WITH CHECK ADD  CONSTRAINT [AirportInformationVersion_PublishedBy] FOREIGN KEY([PublishedById])
REFERENCES [dbo].[Members] ([Id])
GO

ALTER TABLE [dbo].[AirportInformationVersions] CHECK CONSTRAINT [AirportInformationVersion_PublishedBy]
GO

