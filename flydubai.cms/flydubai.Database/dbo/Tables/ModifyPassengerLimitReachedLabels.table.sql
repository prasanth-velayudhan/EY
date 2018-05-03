CREATE TABLE [dbo].[ModifyPassengerLimitReachedLabels] (
    [Language]                          NVARCHAR (128) NOT NULL,
    [PassengerLimitReachedTitleText]    NVARCHAR (MAX) NULL,
    [LimitOfNinePassengersText]         NVARCHAR (MAX) NULL,
    [ForAssistanceText]                 NVARCHAR (MAX) NULL,
    [OkButton]                          NVARCHAR (MAX) NULL,
    [PassengerLimitGreaterThanZeroText] NVARCHAR (MAX) NULL,
    [AsManyAdultsAsInfantsText]         NVARCHAR (MAX) NULL,
    [CannotAddPassangerErrorTitle]      NVARCHAR (MAX) NULL,
    [AddPassangerNoAvailabilityTitle]   NVARCHAR (MAX) NULL,
    [NoAvailabilityToAddTheRequestText] NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([Language] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);

