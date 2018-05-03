ALTER TABLE [dbo].[AirportInformations]  WITH CHECK ADD  CONSTRAINT [AirportInformation_Airport] FOREIGN KEY([AirportCode])
REFERENCES [dbo].[Airports] ([AirportCode])
GO

ALTER TABLE [dbo].[AirportInformations] CHECK CONSTRAINT [AirportInformation_Airport]
GO

