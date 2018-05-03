ALTER TABLE [dbo].[AirportDestinations]  WITH CHECK ADD  CONSTRAINT [AirportDestination_DestinationAirport] FOREIGN KEY([DestinationAirportCode])
REFERENCES [dbo].[Airports] ([AirportCode])
GO

ALTER TABLE [dbo].[AirportDestinations] CHECK CONSTRAINT [AirportDestination_DestinationAirport]
GO

