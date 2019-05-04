CREATE TABLE [dbo].[Feature] (
    [FeatureId]     INT           IDENTITY (1, 1) NOT NULL,
    [Feature]       NVARCHAR (50) NOT NULL,
    [DateTime]      DATETIME      NOT NULL,
    [Price]         DECIMAL (18)  NOT NULL,
    [TourId]        INT           NOT NULL,
    [FeatureTypeId] INT           NOT NULL,
    [TouristId]     INT           NOT NULL,
    [HotelId]       INT           NOT NULL,
    [TourTypeId]    INT           NOT NULL,
    CONSTRAINT [Pk_Feature_FeatureId] PRIMARY KEY CLUSTERED ([FeatureId] ASC),
    CONSTRAINT [Fk_FeatureType_Feature_FeatureTypeId] FOREIGN KEY ([FeatureTypeId]) REFERENCES [dbo].[FeatureType] ([FeatureTypeId]),
    CONSTRAINT [Fk_Tour_Feature_TourId] FOREIGN KEY ([TourId]) REFERENCES [dbo].[Tour] ([TourId])
);

