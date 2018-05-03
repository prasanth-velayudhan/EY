ALTER TABLE [dbo].[SpecialOfferVersionAirport]  WITH CHECK ADD  CONSTRAINT [SpecialOfferVersion_Airports_Target] FOREIGN KEY([AirportCode])
REFERENCES [dbo].[Airports] ([AirportCode])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[SpecialOfferVersionAirport] CHECK CONSTRAINT [SpecialOfferVersion_Airports_Target]
GO

