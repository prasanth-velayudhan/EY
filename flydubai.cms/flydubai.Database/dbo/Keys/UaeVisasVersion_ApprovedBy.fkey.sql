ALTER TABLE [dbo].[UaeVisasVersions]
    ADD CONSTRAINT [UaeVisasVersion_ApprovedBy] FOREIGN KEY ([ApprovedById]) REFERENCES [dbo].[Members] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

