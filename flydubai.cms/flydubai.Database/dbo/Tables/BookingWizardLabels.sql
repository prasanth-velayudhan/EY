CREATE TABLE [dbo].[BookingWizardLabels] (
    [Language]         NVARCHAR (128) NOT NULL,
    [SelectYourFlight] NVARCHAR (MAX) NULL,
    [PassengerDetails] NVARCHAR (MAX) NULL,
    [OptionalExtras]   NVARCHAR (MAX) NULL,
    [Payment]          NVARCHAR (MAX) NULL,
    [Confirmation]     NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([Language] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);

