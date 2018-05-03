ALTER TABLE [dbo].[AirportLocaliseds]  WITH CHECK ADD  CONSTRAINT [AirportLocalised_Airport] FOREIGN KEY([AirportCode])
REFERENCES [dbo].[Airports] ([AirportCode])
GO

ALTER TABLE [dbo].[AirportLocaliseds] CHECK CONSTRAINT [AirportLocalised_Airport]
GO

