﻿ALTER TABLE [dbo].[PaymentPointPartnerTypes]
    ADD CONSTRAINT [PaymentPointPartnerType_Language] FOREIGN KEY ([LanguageId]) REFERENCES [dbo].[Languages] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

