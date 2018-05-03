CREATE TABLE [dbo].[MobileFareTypeLabels] (
    [Language]                           NVARCHAR (128) NOT NULL,
    [AboutOurFareTypes]                  NVARCHAR (MAX) NULL,
    [NoChangeFare]                       NVARCHAR (MAX) NULL,
    [PayToChangeFare]                    NVARCHAR (MAX) NULL,
    [FreeToChangeFare]                   NVARCHAR (MAX) NULL,
    [SevenKgHandBaggageAllowance]        NVARCHAR (MAX) NULL,
    [ChangeOfDatesAllowedAdditionalFee]  NVARCHAR (MAX) NULL,
    [NoRefund]                           NVARCHAR (MAX) NULL,
    [CancellationFeeIs100Percent]        NVARCHAR (MAX) NULL,
    [CheckedBaggageAllowance]            NVARCHAR (MAX) NULL,
    [ChangeOfDatesAllowedOnceFareIsPaid] NVARCHAR (MAX) NULL,
    [AbilityToGetARefund]                NVARCHAR (MAX) NULL,
    [FortyKgCheckedBaggageAllowance]     NVARCHAR (MAX) NULL,
    [BusinessBasicFare]                  NVARCHAR (MAX) NULL,
    [FifteenKgHandBaggageAllowance]      NVARCHAR (MAX) NULL,
    [AbilityToGetARefundBusinessClass]   NVARCHAR (MAX) NULL,
    [ChangeOfDatesAllowedBusinessClass]  NVARCHAR (MAX) NULL,
    [BackToFares]                        NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([Language] ASC)
);



