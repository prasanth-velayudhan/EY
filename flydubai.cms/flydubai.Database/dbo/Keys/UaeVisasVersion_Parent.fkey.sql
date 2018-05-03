ALTER TABLE [dbo].[UaeVisasVersions]
    ADD CONSTRAINT [UaeVisasVersion_Parent] FOREIGN KEY ([ParentId]) REFERENCES [dbo].[UaeVisas] ([HowToApplyUaeVisasId]) ON DELETE NO ACTION ON UPDATE NO ACTION;

