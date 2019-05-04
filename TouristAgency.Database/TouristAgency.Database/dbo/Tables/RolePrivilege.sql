CREATE TABLE [dbo].[RolePrivilege] (
    [RolePrivilegeId] INT IDENTITY (1, 1) NOT NULL,
    [PrivilegeId]     INT NOT NULL,
    [RoleId]          INT NOT NULL,
    CONSTRAINT [Pk_RolePrivilege_RolePrivilegeId] PRIMARY KEY CLUSTERED ([RolePrivilegeId] ASC),
    CONSTRAINT [Fk_Privilege_RolePrivilege_PrivilegeId] FOREIGN KEY ([PrivilegeId]) REFERENCES [dbo].[Privilege] ([PrivilegeId]),
    CONSTRAINT [Fk_Role_RolePrivilege_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [dbo].[Role] ([RoleId])
);

