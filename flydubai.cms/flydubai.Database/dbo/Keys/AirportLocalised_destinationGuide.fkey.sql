ALTER TABLE [dbo].[AirportLocaliseds]  WITH CHECK ADD  CONSTRAINT [AirportLocalised_DestinationGuide] FOREIGN KEY([DestinationGuideId])
REFERENCES [dbo].[DestinationGuides] ([DestinationGuideId])
GO

ALTER TABLE [dbo].[AirportLocaliseds] CHECK CONSTRAINT [AirportLocalised_DestinationGuide]
GO

