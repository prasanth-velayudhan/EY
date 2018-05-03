ALTER TABLE [dbo].[ConfirmationLabels]
    ADD CONSTRAINT [DF_ConfirmationLabels_InformationBeforeYouFlyLinkUrl] 
	DEFAULT ('#') FOR [InformationBeforeYouFlyLinkUrl];
GO
