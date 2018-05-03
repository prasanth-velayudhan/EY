ALTER TABLE [dbo].[ConfirmationLabels]
    ADD CONSTRAINT [DF_ConfirmationLabels_ConfirmationText] 
	DEFAULT ('(Step 5 of 5: All done!)') FOR [ConfirmationText];
GO