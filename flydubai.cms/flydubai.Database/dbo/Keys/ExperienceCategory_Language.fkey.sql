﻿ALTER TABLE [dbo].[ExperienceCategories]
    ADD CONSTRAINT [ExperienceCategory_Language] FOREIGN KEY ([LanguageId]) REFERENCES [dbo].[Languages] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

