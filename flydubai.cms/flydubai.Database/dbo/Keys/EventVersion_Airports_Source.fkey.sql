ALTER TABLE [dbo].[EventVersionAirport]  WITH CHECK ADD  CONSTRAINT [EventVersion_Airports_Source] FOREIGN KEY([EventVersionId])
REFERENCES [dbo].[EventVersions] ([EventVersionId])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[EventVersionAirport] CHECK CONSTRAINT [EventVersion_Airports_Source]
GO

