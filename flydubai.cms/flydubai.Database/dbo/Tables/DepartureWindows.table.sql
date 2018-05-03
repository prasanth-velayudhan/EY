CREATE TABLE [dbo].[DepartureWindows] (
    [DepartureWindowId] INT            IDENTITY (1, 1) NOT NULL,
    [Name]              NVARCHAR (MAX) NULL,
    [Minutes]           INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([DepartureWindowId] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);

