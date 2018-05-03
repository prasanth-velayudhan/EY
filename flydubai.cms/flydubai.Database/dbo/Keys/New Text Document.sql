ALTER TABLE [dbo].[AirportDestinations]
    ADD CONSTRAINT [AirportDestination_DestinationAirport] FOREIGN KEY ([DestinationAirportCode]) REFERENCES [dbo].[Airports] ([AirportCode]) ON DELETE NO ACTION ON UPDATE NO ACTION;

	
	
	
