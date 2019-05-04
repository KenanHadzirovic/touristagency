﻿CREATE TABLE [dbo].[User] (
    [UserId]   INT            IDENTITY (1, 1) NOT NULL,
    [Username] NVARCHAR (50)  NOT NULL,
    [Password] NVARCHAR (300) NOT NULL,
    [RoleId]   INT            NOT NULL,
    CONSTRAINT [Pk_User_UserId] PRIMARY KEY CLUSTERED ([UserId] ASC),
    CONSTRAINT [Fk_Role_User_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [dbo].[Role] ([RoleId])
);

