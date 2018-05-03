CREATE TABLE [dbo].[FareTypeLabels] (
    [FareTypeLabelsId] INT            IDENTITY (1, 1) NOT NULL,
    [FareType1Name]    NVARCHAR (MAX) NULL,
    [FareType2Name]    NVARCHAR (MAX) NULL,
    [FareType3Name]    NVARCHAR (MAX) NULL,
    [FareType1FeeText] NVARCHAR (MAX) NULL,
    [FareType2FeeText] NVARCHAR (MAX) NULL,
    [FareType3FeeText] NVARCHAR (MAX) NULL,
    [LanguageId]       INT            NOT NULL,
    [FareType4Name]    NVARCHAR (MAX) NULL,
    [FareType4FeeText] NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([FareTypeLabelsId] ASC)
);



