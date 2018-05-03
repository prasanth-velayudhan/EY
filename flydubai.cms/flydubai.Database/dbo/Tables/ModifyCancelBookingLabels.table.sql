CREATE TABLE [dbo].[ModifyCancelBookingLabels] (
    [Language]                                              NVARCHAR (128) NOT NULL,
    [CancelBookingTitleText]                                NVARCHAR (MAX) NULL,
    [AreYouSureText]                                        NVARCHAR (MAX) NULL,
    [FareLabelText]                                         NVARCHAR (MAX) NULL,
    [TaxesLabelText]                                        NVARCHAR (MAX) NULL,
    [ServicesSectionLabelText]                              NVARCHAR (MAX) NULL,
    [BaggageLabelText]                                      NVARCHAR (MAX) NULL,
    [SeatingTotalLabelText]                                 NVARCHAR (MAX) NULL,
    [NonRefundableSectionLabelText]                         NVARCHAR (MAX) NULL,
    [InsuranceLabelText]                                    NVARCHAR (MAX) NULL,
    [PenaltyLabelText]                                      NVARCHAR (MAX) NULL,
    [TotalRefundLabelText]                                  NVARCHAR (MAX) NULL,
    [AllRefundsPaidViaVoucherText]                          NVARCHAR (MAX) NULL,
    [CancelBookingButton]                                   NVARCHAR (MAX) NULL,
    [DontCancelBookingButton]                               NVARCHAR (MAX) NULL,
    [YourBookingHasBeenCancelled]                           NVARCHAR (MAX) NULL,
    [FurtherInformationIncludingPINHasBeenSentToEmailBelow] NVARCHAR (MAX) NULL,
    [TermsAndConditions]                                    NVARCHAR (MAX) NULL,
    [IFELabelText]                                          NVARCHAR (MAX) NULL,
    [Meal]                                                  NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([Language] ASC)
);



