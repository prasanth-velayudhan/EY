ALTER TABLE [dbo].[SignUpPreferences]
    ADD CONSTRAINT [SignUpPreferences_Country] FOREIGN KEY ([CountryId]) REFERENCES [dbo].[Countries] ([CountryId]) ON DELETE NO ACTION ON UPDATE NO ACTION;

