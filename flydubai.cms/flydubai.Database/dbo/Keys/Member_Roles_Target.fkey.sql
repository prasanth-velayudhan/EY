ALTER TABLE [dbo].[MemberRole]
    ADD CONSTRAINT [Member_Roles_Target] FOREIGN KEY ([RoleId]) REFERENCES [dbo].[Roles] ([Id]) ON DELETE CASCADE ON UPDATE NO ACTION;

