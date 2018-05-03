﻿CREATE TABLE [dbo].[WebsiteSettings] (
    [WebsiteSettingId] INT            IDENTITY (1, 1) NOT NULL,
    [Key]              NVARCHAR (MAX) NULL,
    [Value]            NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([WebsiteSettingId] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);

