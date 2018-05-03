ALTER TABLE [dbo].[AirportInformationVersions]  WITH CHECK ADD  CONSTRAINT [AirportInformationVersion_ApprovedBy] FOREIGN KEY([ApprovedById])
REFERENCES [dbo].[Members] ([Id])
GO

ALTER TABLE [dbo].[AirportInformationVersions] CHECK CONSTRAINT [AirportInformationVersion_ApprovedBy]
GO

