ALTER TABLE [dbo].[CountryLocaliseds]
    ADD CONSTRAINT [CountryLocalised_Country] FOREIGN KEY ([Country_CountryId]) REFERENCES [dbo].[Countries] ([CountryId]) ON DELETE NO ACTION ON UPDATE NO ACTION;

