CREATE TABLE [dbo].[ModifyCancelSectorLabels] (
    [Language]                            NVARCHAR (128) NOT NULL,
    [CancelSectorTitleText]               NVARCHAR (MAX) NULL,
    [AreYouSureYouWantToCancelSectorText] NVARCHAR (MAX) NULL,
    [ToText]                              NVARCHAR (MAX) NULL,
    [FareLabelText]                       NVARCHAR (MAX) NULL,
    [TaxesLabelText]                      NVARCHAR (MAX) NULL,
    [ServicesSectionLabelText]            NVARCHAR (MAX) NULL,
    [BaggageLabelText]                    NVARCHAR (MAX) NULL,
    [SeatingTotalLabelText]               NVARCHAR (MAX) NULL,
    [NonRefundableSectionLabelText]       NVARCHAR (MAX) NULL,
    [InsuranceLabelText]                  NVARCHAR (MAX) NULL,
    [PenaltyLabelText]                    NVARCHAR (MAX) NULL,
    [TotalRefundLabelText]                NVARCHAR (MAX) NULL,
    [AllRefundsPaidViaVoucherText]        NVARCHAR (MAX) NULL,
    [CancelSectorButton]                  NVARCHAR (MAX) NULL,
    [DontCancelSectorButton]              NVARCHAR (MAX) NULL,
    [IFELabelText]                        NVARCHAR (MAX) NULL,
    [Meal]                                NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([Language] ASC)
);



