ALTER TABLE [dbo].[GlobalPRContacts]  WITH CHECK ADD  CONSTRAINT [GlobalPRContact_Language] FOREIGN KEY([LanguageId])
REFERENCES [dbo].[Languages] ([Id])
GO

ALTER TABLE [dbo].[GlobalPRContacts] CHECK CONSTRAINT [GlobalPRContact_Language]
GO

