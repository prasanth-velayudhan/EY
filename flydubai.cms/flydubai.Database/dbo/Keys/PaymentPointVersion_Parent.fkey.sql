ALTER TABLE [dbo].[PaymentPointVersions]
    ADD CONSTRAINT [PaymentPointVersion_Parent] FOREIGN KEY ([ParentId]) REFERENCES [dbo].[PaymentPoints] ([PaymentPointId]) ON DELETE NO ACTION ON UPDATE NO ACTION;

