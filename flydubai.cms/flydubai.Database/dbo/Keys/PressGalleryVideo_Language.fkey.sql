ALTER TABLE [dbo].[PressGalleryVideos]
    ADD CONSTRAINT [PressGalleryVideo_Language] FOREIGN KEY ([LanguageId]) REFERENCES [dbo].[Languages] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

