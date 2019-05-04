CREATE TABLE [dbo].[Tourist] (
    [TouristId]   INT            IDENTITY (0, 1) NOT NULL,
    [FirstName]   NVARCHAR (50)  NOT NULL,
    [LastName]    NVARCHAR (50)  NOT NULL,
    [SSN]         NVARCHAR (13)  NOT NULL,
    [DateOfBirth] DATE           NOT NULL,
    [Address]     NVARCHAR (100) NOT NULL,
    CONSTRAINT [Pk_Tourist_TouristId] PRIMARY KEY CLUSTERED ([TouristId] ASC)
);

