CREATE TABLE [dbo].[ModifyChangeDateLabels] (
    [Language]                               NVARCHAR (128) NOT NULL,
    [ChangeDateTitleText]                    NVARCHAR (MAX) NULL,
    [ToText]                                 NVARCHAR (MAX) NULL,
    [FlexibleOnDatesCheckbox]                NVARCHAR (MAX) NULL,
    [NoRefundMessageText]                    NVARCHAR (MAX) NULL,
    [NoChangeText]                           NVARCHAR (MAX) NULL,
    [NoRefundText]                           NVARCHAR (MAX) NULL,
    [ChangesApplyToAllPassengersText]        NVARCHAR (MAX) NULL,
    [FindAlternativeSectorButton]            NVARCHAR (MAX) NULL,
    [InsuranceOutOfCoverage]                 NVARCHAR (MAX) NULL,
    [InsuranceOutOfCoveredForTheFirst90Days] NVARCHAR (MAX) NULL,
    [Cancel]                                 NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([Language] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);

