CREATE TABLE [dbo].[ModifyOptionalExtrasLabels] (
    [Language]                               NVARCHAR (128) NOT NULL,
    [SeatNoLongerAvailableHeadingText]       NVARCHAR (MAX) NULL,
    [SeatNoLongerAvailableHowToContinueText] NVARCHAR (MAX) NULL,
    [SaveChangesButton]                      NVARCHAR (MAX) NULL,
    [CancelChangesButton]                    NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([Language] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);

