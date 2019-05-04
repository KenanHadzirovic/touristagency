CREATE TABLE [dbo].[Privilege] (
    [PrivilegeId] INT           IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (50) NOT NULL,
    [Description] TEXT          NULL,
    CONSTRAINT [Pk_Privilege_PrivilegeId] PRIMARY KEY CLUSTERED ([PrivilegeId] ASC)
);

