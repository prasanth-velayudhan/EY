ALTER TABLE [dbo].[AirportDestinations] ADD CONSTRAINT [Airport_Destinations] FOREIGN KEY([OriginAirportCode])
REFERENCES [dbo].[Airports] ([AirportCode])
GO

ALTER TABLE [dbo].[AirportDestinations] CHECK CONSTRAINT [Airport_Destinations]
GO

