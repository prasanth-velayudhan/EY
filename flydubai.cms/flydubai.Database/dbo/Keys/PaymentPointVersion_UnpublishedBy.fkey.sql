ALTER TABLE [dbo].[PaymentPointVersions]
    ADD CONSTRAINT [PaymentPointVersion_UnpublishedBy] FOREIGN KEY ([UnpublishedById]) REFERENCES [dbo].[Members] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

