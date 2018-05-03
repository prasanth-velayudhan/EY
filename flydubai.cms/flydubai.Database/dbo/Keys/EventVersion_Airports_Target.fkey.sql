ALTER TABLE [dbo].[EventVersionAirport]  WITH CHECK ADD  CONSTRAINT [EventVersion_Airports_Target] FOREIGN KEY([AirportCode])
REFERENCES [dbo].[Airports] ([AirportCode])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[EventVersionAirport] CHECK CONSTRAINT [EventVersion_Airports_Target]
GO

