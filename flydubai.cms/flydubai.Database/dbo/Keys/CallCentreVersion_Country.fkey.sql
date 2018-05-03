ALTER TABLE [dbo].[CallCentreVersions]
    ADD CONSTRAINT [CallCentreVersion_Country] FOREIGN KEY ([CountryId]) REFERENCES [dbo].[Countries] ([CountryId]) ON DELETE NO ACTION ON UPDATE NO ACTION;

