ALTER TABLE [dbo].[ConfirmationLabels]
    ADD CONSTRAINT [DF_ConfirmationLabels_ConfirmationHeader] 
	DEFAULT ('Confirmation') FOR [ConfirmationHeader];
GO
