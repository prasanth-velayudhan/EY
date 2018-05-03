ALTER TABLE [dbo].[CareersFooters]
    ADD CONSTRAINT [CareersFooter_Language] FOREIGN KEY ([LanguageId]) REFERENCES [dbo].[Languages] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

