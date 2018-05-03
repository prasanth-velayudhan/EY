ALTER TABLE [dbo].[EmergencyUpdates]
    ADD CONSTRAINT [EmergencyUpdate_Emergency] FOREIGN KEY ([EmergencyId]) REFERENCES [dbo].[Emergencies] ([EmergencyId]) ON DELETE NO ACTION ON UPDATE NO ACTION;

