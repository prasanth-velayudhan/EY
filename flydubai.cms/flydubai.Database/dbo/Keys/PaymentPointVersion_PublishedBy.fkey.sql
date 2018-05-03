ALTER TABLE [dbo].[PaymentPointVersions]
    ADD CONSTRAINT [PaymentPointVersion_PublishedBy] FOREIGN KEY ([PublishedById]) REFERENCES [dbo].[Members] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

