ALTER TABLE [dbo].[CustomPageLocaliseds]  
	ADD  CONSTRAINT [FK_CustomPageLocaliseds_CustomPages] FOREIGN KEY([CustomPageId]) REFERENCES [dbo].[CustomPages] ([CustomPageId]);
