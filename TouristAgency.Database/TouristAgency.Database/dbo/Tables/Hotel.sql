CREATE TABLE [dbo].[Hotel] (
    [HotelId] INT            IDENTITY (1, 1) NOT NULL,
    [Name]    NVARCHAR (50)  NOT NULL,
    [Address] NVARCHAR (100) NOT NULL,
    [City]    NVARCHAR (50)  NOT NULL,
    [Country] NVARCHAR (50)  NOT NULL,
    [Stars]   SMALLINT       NOT NULL,
    [Phone]   NVARCHAR (15)  NOT NULL,
    [Website] NVARCHAR (50)  NOT NULL,
    CONSTRAINT [Pk_Hotel_HotelId] PRIMARY KEY CLUSTERED ([HotelId] ASC)
);

