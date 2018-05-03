CREATE TABLE [dbo].[FareTypes] (
    [FareTypeId]       INT            IDENTITY (1, 1) NOT NULL,
    [LanguageId]       INT            NOT NULL,
    [Index]            INT            NOT NULL,
    [RowName]          NVARCHAR (MAX) NULL,
    [Fare1Image]       INT            NULL,
    [Fare1ImageUrl]    NVARCHAR (MAX) NULL,
    [Fare1Description] NVARCHAR (MAX) NULL,
    [Fare2Image]       INT            NULL,
    [Fare2ImageUrl]    NVARCHAR (MAX) NULL,
    [Fare2Description] NVARCHAR (MAX) NULL,
    [Fare3Image]       INT            NULL,
    [Fare3ImageUrl]    NVARCHAR (MAX) NULL,
    [Fare3Description] NVARCHAR (MAX) NULL,
    [Fare4Image]       INT            NULL,
    [Fare4ImageUrl]    NVARCHAR (MAX) NULL,
    [Fare4Description] NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([FareTypeId] ASC)
);



