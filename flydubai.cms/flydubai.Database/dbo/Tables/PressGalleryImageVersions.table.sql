﻿CREATE TABLE [dbo].[PressGalleryImageVersions] (
    [PressGalleryImageVersionId] INT            IDENTITY (1, 1) NOT NULL,
    [Name]                       NVARCHAR (MAX) NULL,
    [Category]                   NVARCHAR (MAX) NULL,
    [Thumbnail]                  INT            NULL,
    [Preview]                    INT            NULL,
    [SmallFileName]              NVARCHAR (MAX) NULL,
    [SmallDownloadFileName]      NVARCHAR (MAX) NULL,
    [SmallResolution]            NVARCHAR (MAX) NULL,
    [SmallFileSize]              NVARCHAR (MAX) NULL,
    [MediumFileName]             NVARCHAR (MAX) NULL,
    [MediumDownloadFileName]     NVARCHAR (MAX) NULL,
    [MediumResolution]           NVARCHAR (MAX) NULL,
    [MediumFileSize]             NVARCHAR (MAX) NULL,
    [LargeFileName]              NVARCHAR (MAX) NULL,
    [LargeDownloadFileName]      NVARCHAR (MAX) NULL,
    [LargeResolution]            NVARCHAR (MAX) NULL,
    [LargeFileSize]              NVARCHAR (MAX) NULL,
    [ParentId]                   INT            NOT NULL,
    [UrlIdentifier]              NVARCHAR (MAX) NULL,
    [CmsName]                    NVARCHAR (MAX) NULL,
    [Version]                    INT            NOT NULL,
    [IsDraft]                    BIT            NOT NULL,
    [CreatedById]                INT            NULL,
    [CreatedDate]                DATETIME2 (7)  NULL,
    [ApprovedById]               INT            NULL,
    [ApprovedDate]               DATETIME2 (7)  NULL,
    [PublishedById]              INT            NULL,
    [PublishedDate]              DATETIME2 (7)  NULL,
    [UnpublishedById]            INT            NULL,
    [UnpublishedDate]            DATETIME2 (7)  NULL,
    PRIMARY KEY CLUSTERED ([PressGalleryImageVersionId] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);

