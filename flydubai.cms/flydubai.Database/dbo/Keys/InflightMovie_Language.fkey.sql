ALTER TABLE [dbo].[InflightMovies]
    ADD CONSTRAINT [InflightMovie_Language] FOREIGN KEY ([LanguageId]) REFERENCES [dbo].[Languages] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

