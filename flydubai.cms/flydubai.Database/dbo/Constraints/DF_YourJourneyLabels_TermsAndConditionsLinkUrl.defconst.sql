--BEGIN
--ALTER TABLE [dbo].[YourJourneyLabels] DROP CONSTRAINT [DF_YourJourneyLabels_TermsAndConditionsLinkUrl]
--END

--GO

--ALTER TABLE [dbo].[YourJourneyLabels] ADD  CONSTRAINT [DF_YourJourneyLabels_TermsAndConditionsLinkUrl]  DEFAULT ('#') FOR [TermsAndConditionsLinkUrl]
--GO
