CREATE TABLE [dbo].[Tour] (
    [TourId]     INT IDENTITY (1, 1) NOT NULL,
    [TouristId]  INT NOT NULL,
    [HotelId]    INT NOT NULL,
    [TourTypeId] INT NOT NULL,
    CONSTRAINT [Pk_Tour_TourId] PRIMARY KEY CLUSTERED ([TourId] ASC),
    CONSTRAINT [Fk_Hotel_Tour_HotelId] FOREIGN KEY ([HotelId]) REFERENCES [dbo].[Hotel] ([HotelId]),
    CONSTRAINT [Fk_Tourist_Tour_TouristId] FOREIGN KEY ([TouristId]) REFERENCES [dbo].[Tourist] ([TouristId]),
    CONSTRAINT [Fk_TourType_Tour_TourTypeId] FOREIGN KEY ([TourTypeId]) REFERENCES [dbo].[TourType] ([TourTypeId])
);

