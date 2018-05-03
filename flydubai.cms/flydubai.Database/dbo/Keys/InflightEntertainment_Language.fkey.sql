ALTER TABLE [dbo].[InflightEntertainments]
    ADD CONSTRAINT [InflightEntertainment_Language] FOREIGN KEY ([LanguageId]) REFERENCES [dbo].[Languages] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

