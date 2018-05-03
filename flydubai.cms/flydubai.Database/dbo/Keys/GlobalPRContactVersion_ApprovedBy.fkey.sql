ALTER TABLE [dbo].[GlobalPRContactVersions]  WITH CHECK ADD  CONSTRAINT [GlobalPRContactVersion_ApprovedBy] FOREIGN KEY([ApprovedById])
REFERENCES [dbo].[Members] ([Id])
GO

ALTER TABLE [dbo].[GlobalPRContactVersions] CHECK CONSTRAINT [GlobalPRContactVersion_ApprovedBy]
GO

