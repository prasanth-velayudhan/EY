ALTER TABLE [dbo].[PressGalleryImages]
    ADD CONSTRAINT [PressGalleryImage_Language] FOREIGN KEY ([LanguageId]) REFERENCES [dbo].[Languages] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

