CREATE TABLE [dbo].[ModifyProgressBarLabels] (
    [Language]            NVARCHAR (128) NOT NULL,
    [AmendBookingText]    NVARCHAR (MAX) NULL,
    [SelectSectorsText]   NVARCHAR (MAX) NULL,
    [SeatsAndBaggageText] NVARCHAR (MAX) NULL,
    [ConfirmChangesText]  NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([Language] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);

