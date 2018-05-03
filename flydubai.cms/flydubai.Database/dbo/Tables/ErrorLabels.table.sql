CREATE TABLE [dbo].[ErrorLabels] (
    [Language]                                    NVARCHAR (128) NOT NULL,
    [PaymentFailure]                              NVARCHAR (MAX) NULL,
    [SessionExpired]                              NVARCHAR (MAX) NULL,
    [GoToHomePage]                                NVARCHAR (MAX) NULL,
    [ThePageYouAreLookingForCouldNotBeFound]      NVARCHAR (MAX) NULL,
    [ReturnToViewBookingLinkText]                 NVARCHAR (MAX) NULL,
    [MessageForUnrecoverableErrorDuringCreatePNR] NVARCHAR (MAX) NULL,
    [MessageForUnrecoverableErrorDuringModifyPNR] NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([Language] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);

