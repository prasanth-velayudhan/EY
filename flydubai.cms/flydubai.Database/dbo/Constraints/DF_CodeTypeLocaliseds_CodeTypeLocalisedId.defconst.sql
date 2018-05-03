ALTER TABLE [dbo].[CodeTypeLocaliseds]  
	ADD  CONSTRAINT [CodeTypeLocalised_CodeType] FOREIGN KEY([CodeType_CodeTypeId]) REFERENCES [dbo].[CodeTypes] ([CodeTypeId]);
