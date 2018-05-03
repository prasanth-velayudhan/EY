ALTER TABLE [dbo].[GlobalPRContactVersions]  WITH CHECK ADD  CONSTRAINT [GlobalPRContactVersion_CreatedBy] FOREIGN KEY([CreatedById])
REFERENCES [dbo].[Members] ([Id])
GO

ALTER TABLE [dbo].[GlobalPRContactVersions] CHECK CONSTRAINT [GlobalPRContactVersion_CreatedBy]
GO

