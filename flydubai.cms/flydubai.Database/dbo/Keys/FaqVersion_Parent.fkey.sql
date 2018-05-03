ALTER TABLE [dbo].[FaqVersions]
    ADD CONSTRAINT [FaqVersion_Parent] FOREIGN KEY ([ParentId]) REFERENCES [dbo].[Faqs] ([FaqId]) ON DELETE NO ACTION ON UPDATE NO ACTION;

