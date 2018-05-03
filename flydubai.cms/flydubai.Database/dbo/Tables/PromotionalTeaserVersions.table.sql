﻿CREATE TABLE [dbo].[PromotionalTeaserVersions] (
    [PromotionalTeaserVersionId] INT            IDENTITY (1, 1) NOT NULL,
    [Title]                      NVARCHAR (MAX) NULL,
    [DescriptionHtml]            NVARCHAR (MAX) NULL,
    [SmallImage]                 INT            NULL,
    [SmallImagePath]             NVARCHAR (MAX) NULL,
    [MainImage]                  INT            NULL,
    [MainImagePath]              NVARCHAR (MAX) NULL,
    [BookNowUrl]                 NVARCHAR (MAX) NULL,
    [OpenInNewWindow]            BIT            NULL,
    [ShowOnProfile]              BIT            NOT NULL,
    [ShowOnConfirmation]         BIT            NOT NULL,
    [ImageOnly]                  BIT            NOT NULL,
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
    [TABookNowUrl]               NVARCHAR (MAX) NULL,
    [TAMainImagePath]            NVARCHAR (MAX) NULL,
    [TAMainImage]                INT            NULL,
    [ShowBannerOnBottom]         BIT            DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([PromotionalTeaserVersionId] ASC)
);



