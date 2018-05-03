CREATE TABLE [dbo].[SurveyLightBoxes] (
    [Language]       NVARCHAR (10)  NOT NULL,
    [LightBoxLabel]  NVARCHAR (MAX) NOT NULL,
    [YesButtonText]  NVARCHAR (MAX) NOT NULL,
    [NoButtonText]   NVARCHAR (MAX) NOT NULL,
    [YesButtonUrl]   NVARCHAR (MAX) NOT NULL,
    [IsSurveyActive] BIT            NOT NULL,
    [ContentText]    NVARCHAR (MAX) NULL
);

