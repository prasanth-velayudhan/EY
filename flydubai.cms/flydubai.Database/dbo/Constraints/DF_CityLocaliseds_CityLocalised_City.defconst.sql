ALTER TABLE [dbo].[CityLocaliseds]  
	ADD  CONSTRAINT [CityLocalised_City] FOREIGN KEY([City_CityId]) REFERENCES [dbo].[Cities] ([CityId]);
