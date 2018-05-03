ALTER TABLE [dbo].[GlobalPRContactVersions]  WITH CHECK ADD  CONSTRAINT [GlobalPRContactVersion_Parent] FOREIGN KEY([ParentId])
REFERENCES [dbo].[GlobalPRContacts] ([GlobalPRContactId])
GO

ALTER TABLE [dbo].[GlobalPRContactVersions] CHECK CONSTRAINT [GlobalPRContactVersion_Parent]
GO

