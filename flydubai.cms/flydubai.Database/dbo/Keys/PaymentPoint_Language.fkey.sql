﻿ALTER TABLE [dbo].[PaymentPoints]
    ADD CONSTRAINT [PaymentPoint_Language] FOREIGN KEY ([LanguageId]) REFERENCES [dbo].[Languages] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

