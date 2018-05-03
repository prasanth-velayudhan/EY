ALTER TABLE [dbo].[GlobalPRContactVersions]  WITH CHECK ADD  CONSTRAINT [GlobalPRContactVersion_PublishedBy] FOREIGN KEY([PublishedById])
REFERENCES [dbo].[Members] ([Id])
GO

ALTER TABLE [dbo].[GlobalPRContactVersions] CHECK CONSTRAINT [GlobalPRContactVersion_PublishedBy]
GO

