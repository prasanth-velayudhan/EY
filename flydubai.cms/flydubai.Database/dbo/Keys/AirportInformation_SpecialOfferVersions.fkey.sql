ALTER TABLE [dbo].[SpecialOfferVersions]  WITH CHECK ADD  CONSTRAINT [AirportInformation_SpecialOfferVersions] FOREIGN KEY([AirportInformation_AirportInformationId])
REFERENCES [dbo].[AirportInformations] ([AirportInformationId])
GO

ALTER TABLE [dbo].[SpecialOfferVersions] CHECK CONSTRAINT [AirportInformation_SpecialOfferVersions]
GO

