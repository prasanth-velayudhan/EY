CREATE TABLE [dbo].[CarHireLabels] (
    [CarHireLabelsId] INT            IDENTITY (1, 1) NOT NULL,
    [CarRental]       NVARCHAR (MAX) NULL,
    [CarHire]         NVARCHAR (MAX) NULL,
    [LanguageId]      INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([CarHireLabelsId] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);

