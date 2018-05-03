ALTER TABLE [dbo].[PaymentPointVersions]
    ADD CONSTRAINT [PaymentPointVersion_CreatedBy] FOREIGN KEY ([CreatedById]) REFERENCES [dbo].[Members] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

