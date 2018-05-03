ALTER TABLE [dbo].[CallCentreVersions]
    ADD CONSTRAINT [CallCentreVersion_Parent] FOREIGN KEY ([ParentId]) REFERENCES [dbo].[CallCentres] ([CallCentreId]) ON DELETE NO ACTION ON UPDATE NO ACTION;

