ALTER TABLE [dbo].[UaeVisasVersions]
    ADD CONSTRAINT [UaeVisasVersion_CreatedBy] FOREIGN KEY ([CreatedById]) REFERENCES [dbo].[Members] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

