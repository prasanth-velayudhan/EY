ALTER TABLE [dbo].[PaymentPointVersions]
    ADD CONSTRAINT [PaymentPointVersion_PaymentPointPartnerType] FOREIGN KEY ([PaymentPointPartnerTypeId]) REFERENCES [dbo].[PaymentPointPartnerTypes] ([PaymentPointPartnerTypeId]) ON DELETE NO ACTION ON UPDATE NO ACTION;

