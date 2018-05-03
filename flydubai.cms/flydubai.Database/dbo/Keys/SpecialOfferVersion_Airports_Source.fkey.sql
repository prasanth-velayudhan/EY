ALTER TABLE [dbo].[SpecialOfferVersionAirport]  WITH CHECK ADD  CONSTRAINT [SpecialOfferVersion_Airports_Source] FOREIGN KEY([SpecialOfferVersionId])
REFERENCES [dbo].[SpecialOfferVersions] ([SpecialOfferVersionId])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[SpecialOfferVersionAirport] CHECK CONSTRAINT [SpecialOfferVersion_Airports_Source]
GO

