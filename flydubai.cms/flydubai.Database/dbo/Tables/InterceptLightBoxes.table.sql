CREATE TABLE [dbo].[InterceptLightBoxes] (
    [Language]      NVARCHAR (10)  NOT NULL,
    [LightBoxLabel] NVARCHAR (MAX) NOT NULL,
    [YesButtonText] NVARCHAR (MAX) NOT NULL,
    [NoButtonText]  NVARCHAR (MAX) NOT NULL,
    [ContentText]   NVARCHAR (MAX) NULL
);

