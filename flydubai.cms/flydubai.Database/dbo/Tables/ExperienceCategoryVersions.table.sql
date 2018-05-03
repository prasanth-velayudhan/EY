﻿CREATE TABLE [dbo].[ExperienceCategoryVersions] (
    [ExperienceCategoryVersionId] INT            IDENTITY (1, 1) NOT NULL,
    [Name]                        NVARCHAR (MAX) NULL,
    [Description]                 NVARCHAR (MAX) NULL,
    [Url]                         NVARCHAR (MAX) NULL,
    [UrlText]                     NVARCHAR (MAX) NULL,
    [ParentId]                    INT            NOT NULL,
    [UrlIdentifier]               NVARCHAR (MAX) NULL,
    [CmsName]                     NVARCHAR (MAX) NULL,
    [Version]                     INT            NOT NULL,
    [IsDraft]                     BIT            NOT NULL,
    [CreatedById]                 INT            NULL,
    [CreatedDate]                 DATETIME2 (7)  NULL,
    [ApprovedById]                INT            NULL,
    [ApprovedDate]                DATETIME2 (7)  NULL,
    [PublishedById]               INT            NULL,
    [PublishedDate]               DATETIME2 (7)  NULL,
    [UnpublishedById]             INT            NULL,
    [UnpublishedDate]             DATETIME2 (7)  NULL,
    PRIMARY KEY CLUSTERED ([ExperienceCategoryVersionId] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);

