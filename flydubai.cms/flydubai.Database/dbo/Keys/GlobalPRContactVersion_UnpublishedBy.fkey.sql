ALTER TABLE [dbo].[GlobalPRContactVersions]  WITH CHECK ADD  CONSTRAINT [GlobalPRContactVersion_UnpublishedBy] FOREIGN KEY([UnpublishedById])
REFERENCES [dbo].[Members] ([Id])
GO

ALTER TABLE [dbo].[GlobalPRContactVersions] CHECK CONSTRAINT [GlobalPRContactVersion_UnpublishedBy]
GO

