CREATE TABLE [dbo].[ModifyRemovePassengerLabels] (
    [Language]                     NVARCHAR (128) NOT NULL,
    [RemovePassengerTitleText]     NVARCHAR (MAX) NULL,
    [RemovePassengerFromText]      NVARCHAR (MAX) NULL,
    [FareLabelText]                NVARCHAR (MAX) NULL,
    [TaxesLabelText]               NVARCHAR (MAX) NULL,
    [ServicesSectionLabelText]     NVARCHAR (MAX) NULL,
    [BaggageLabelText]             NVARCHAR (MAX) NULL,
    [SeatingTotalLabelText]        NVARCHAR (MAX) NULL,
    [NonRefundableLabelText]       NVARCHAR (MAX) NULL,
    [InsuranceLabelText]           NVARCHAR (MAX) NULL,
    [PenaltyLabelText]             NVARCHAR (MAX) NULL,
    [TotalRefundLabelText]         NVARCHAR (MAX) NULL,
    [AllRefundsPaidViaVoucherText] NVARCHAR (MAX) NULL,
    [RemovePassengerButton]        NVARCHAR (MAX) NULL,
    [DontRemovePassengerButton]    NVARCHAR (MAX) NULL,
    [IFETotalLabelText]            NVARCHAR (MAX) NULL,
    [MealLabelText]                NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([Language] ASC)
);



