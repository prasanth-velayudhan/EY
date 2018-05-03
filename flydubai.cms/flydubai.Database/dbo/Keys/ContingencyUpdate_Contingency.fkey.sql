ALTER TABLE [dbo].[ContingencyUpdates]
    ADD CONSTRAINT [ContingencyUpdate_Contingency] FOREIGN KEY ([ContingencyId]) REFERENCES [dbo].[Contingencies] ([ContingencyId]) ON DELETE NO ACTION ON UPDATE NO ACTION;

