ALTER TABLE [dbo].[AirportInformations] ADD CONSTRAINT [AirportInformation_Language] FOREIGN KEY([LanguageId])
REFERENCES [dbo].[Languages] ([Id])
GO

ALTER TABLE [dbo].[AirportInformations] CHECK CONSTRAINT [AirportInformation_Language]
GO

