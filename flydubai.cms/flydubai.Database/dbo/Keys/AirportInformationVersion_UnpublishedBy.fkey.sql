ALTER TABLE [dbo].[AirportInformationVersions]  WITH CHECK ADD  CONSTRAINT [AirportInformationVersion_UnpublishedBy] FOREIGN KEY([UnpublishedById])
REFERENCES [dbo].[Members] ([Id])
GO

ALTER TABLE [dbo].[AirportInformationVersions] CHECK CONSTRAINT [AirportInformationVersion_UnpublishedBy]
GO

