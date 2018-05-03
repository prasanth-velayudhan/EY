CREATE TABLE [dbo].[ModifyAddPassengersLabels] (
    [Language]                      NVARCHAR (128) NOT NULL,
    [AddPassengersTitleText]        NVARCHAR (MAX) NULL,
    [HowManyPassengersText]         NVARCHAR (MAX) NULL,
    [AddPassengersToAllSectorsText] NVARCHAR (MAX) NULL,
    [AdultsLabelText]               NVARCHAR (MAX) NULL,
    [TwelvePlusYearsLabelText]      NVARCHAR (MAX) NULL,
    [ChildrenLabelText]             NVARCHAR (MAX) NULL,
    [TwoToTwelveYearsLabelText]     NVARCHAR (MAX) NULL,
    [InfantsLabelText]              NVARCHAR (MAX) NULL,
    [UnderTwoYearsLabelText]        NVARCHAR (MAX) NULL,
    [AddMoreThanNinePassengersText] NVARCHAR (MAX) NULL,
    [CheckAvailabilityButton]       NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([Language] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);

