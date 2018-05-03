ALTER TABLE [dbo].[Airports] ADD  CONSTRAINT [DF_AirportCode_Active]  DEFAULT ((1)) FOR [Active]
GO

