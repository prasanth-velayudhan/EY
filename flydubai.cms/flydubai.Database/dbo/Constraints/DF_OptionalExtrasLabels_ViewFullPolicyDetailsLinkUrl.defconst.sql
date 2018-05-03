--BEGIN
--ALTER TABLE [dbo].[OptionalExtrasLabels] DROP CONSTRAINT [DF_OptionalExtrasLabels_ViewFullPolicyDetailsLinkUrl]
--END

--GO

--ALTER TABLE [dbo].[OptionalExtrasLabels] ADD  CONSTRAINT [DF_OptionalExtrasLabels_ViewFullPolicyDetailsLinkUrl]  DEFAULT ('#') FOR [ViewFullPolicyDetailsLinkUrl]
--GO
