ALTER TABLE [dbo].[ContactSubjects]
    ADD CONSTRAINT [ContactSubject_Language] FOREIGN KEY ([LanguageId]) REFERENCES [dbo].[Languages] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

