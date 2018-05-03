ALTER TABLE [dbo].[Cities]
    ADD CONSTRAINT [City_Country] FOREIGN KEY ([CountryId]) REFERENCES [dbo].[Countries] ([CountryId]) ON DELETE NO ACTION ON UPDATE NO ACTION;

