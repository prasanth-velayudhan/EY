﻿CREATE TABLE [dbo].[ModifyChangeDateResultsLabels] (
    [Language]                      NVARCHAR (128) NOT NULL,
    [CurrentSectorTitleText]        NVARCHAR (MAX) NULL,
    [ChooseSectorAndContinueButton] NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([Language] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);

