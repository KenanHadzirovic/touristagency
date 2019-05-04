CREATE TABLE [dbo].[TourType] (
    [TourTypeId]  INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (50)  NOT NULL,
    [Description] TEXT           NOT NULL,
    [DateFrom]    DATE           NOT NULL,
    [DateTo]      DATE           NOT NULL,
    [Location]    NVARCHAR (50)  NOT NULL,
    [MaxTourists] SMALLINT       NULL,
    [Price]       DECIMAL (4, 2) NOT NULL,
    [PricePerDay] BIT            NOT NULL,
    CONSTRAINT [Pk_TourType_TourTypeId] PRIMARY KEY CLUSTERED ([TourTypeId] ASC)
);

