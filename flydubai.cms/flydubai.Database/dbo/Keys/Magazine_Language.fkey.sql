﻿ALTER TABLE [dbo].[Magazines]
    ADD CONSTRAINT [Magazine_Language] FOREIGN KEY ([LanguageId]) REFERENCES [dbo].[Languages] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

