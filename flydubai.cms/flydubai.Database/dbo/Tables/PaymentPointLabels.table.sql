CREATE TABLE [dbo].[PaymentPointLabels] (
    [PaymentPointLabelsId]            INT            IDENTITY (1, 1) NOT NULL,
    [HeadingText]                     NVARCHAR (MAX) NULL,
    [SearchInstructions]              NVARCHAR (MAX) NULL,
    [CountryLabel]                    NVARCHAR (MAX) NULL,
    [CityLabel]                       NVARCHAR (MAX) NULL,
    [PartnerType]                     NVARCHAR (MAX) NULL,
    [LocateButtonText]                NVARCHAR (MAX) NULL,
    [PrintMapButtonText]              NVARCHAR (MAX) NULL,
    [EmailMapButtonText]              NVARCHAR (MAX) NULL,
    [ResultsFoundFormat]              NVARCHAR (MAX) NULL,
    [BlankDropDownOptionText]         NVARCHAR (MAX) NULL,
    [NoResults]                       NVARCHAR (MAX) NULL,
    [PaymentPointLocatorHeading]      NVARCHAR (MAX) NULL,
    [PaymentPointLocatorInstructions] NVARCHAR (MAX) NULL,
    [LanguageId]                      INT            NOT NULL,
    [EmailPaymentPointsLegend]        NVARCHAR (MAX) NULL,
    [EmailPaymentPointsSendButton]    NVARCHAR (MAX) NULL,
    [EmailPaymentPointsCancelButton]  NVARCHAR (MAX) NULL,
    [PaymentPointsEmailFail]          NVARCHAR (MAX) NULL,
    [PaymentPointsValidEmailError]    NVARCHAR (MAX) NULL,
    [PaymentPointsEmailSuccess]       NVARCHAR (MAX) NOT NULL,
    [PaymentPointsEmailSubject]       NVARCHAR (MAX) NOT NULL,
    PRIMARY KEY CLUSTERED ([PaymentPointLabelsId] ASC)
);



