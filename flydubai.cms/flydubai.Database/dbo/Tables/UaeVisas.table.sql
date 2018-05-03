﻿CREATE TABLE [dbo].[UaeVisas] (
    [HowToApplyUaeVisasId] INT IDENTITY (1, 1) NOT NULL,
    [LanguageId]           INT NOT NULL,
    PRIMARY KEY CLUSTERED ([HowToApplyUaeVisasId] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);

