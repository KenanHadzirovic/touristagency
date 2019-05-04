CREATE TABLE [dbo].[FeatureType] (
    [FeatureTypeId] INT           IDENTITY (1, 1) NOT NULL,
    [Name]          NVARCHAR (50) NOT NULL,
    [Description]   TEXT          NOT NULL,
    CONSTRAINT [Pk_FeatureType_FeatureTypeId] PRIMARY KEY CLUSTERED ([FeatureTypeId] ASC)
);

