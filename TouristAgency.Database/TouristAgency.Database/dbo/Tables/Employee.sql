CREATE TABLE [dbo].[Employee] (
    [EmployeeId]  INT            IDENTITY (1, 1) NOT NULL,
    [FirstName]   NVARCHAR (50)  NOT NULL,
    [LastName]    NVARCHAR (50)  NOT NULL,
    [DateOfBirth] DATETIME       NOT NULL,
    [Address]     NVARCHAR (100) NOT NULL,
    [PhoneNumber] NVARCHAR (12)  NOT NULL,
    [UserId]      INT            NOT NULL,
    CONSTRAINT [Pk_Employee_EmployeeId] PRIMARY KEY CLUSTERED ([EmployeeId] ASC),
    CONSTRAINT [Fk_User_Employee_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[UserAccount] ([UserAccountId])
);

