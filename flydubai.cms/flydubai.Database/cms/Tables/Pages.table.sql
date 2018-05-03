﻿CREATE TABLE [cms].[Pages] (
    [PageId]       INT            IDENTITY (1, 1) NOT NULL,
    [PageCode]     NVARCHAR (MAX) NULL,
    [Description]  NVARCHAR (MAX) NULL,
    [PageXml]      NVARCHAR (MAX) NULL,
    [PreviewXml]   NVARCHAR (MAX) NULL,
    [UserDefined]  BIT            NOT NULL,
    [DateCreated]  DATETIME2 (7)  NOT NULL,
    [CreatedBy]    INT            NOT NULL,
    [DateModified] DATETIME2 (7)  NOT NULL,
    [ModifiedBy]   INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([PageId] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);

