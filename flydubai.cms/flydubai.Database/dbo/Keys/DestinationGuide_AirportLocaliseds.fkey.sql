ALTER TABLE [dbo].[AirportLocaliseds]  WITH CHECK ADD  CONSTRAINT [DestinationGuide_AirportLocaliseds] FOREIGN KEY([DestinationGuideId])
REFERENCES [dbo].[DestinationGuides] ([DestinationGuideId])
GO

ALTER TABLE [dbo].[AirportLocaliseds] CHECK CONSTRAINT [DestinationGuide_AirportLocaliseds]
GO

