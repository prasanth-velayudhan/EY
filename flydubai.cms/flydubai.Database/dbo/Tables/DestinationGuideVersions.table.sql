CREATE TABLE [dbo].[DestinationGuideVersions] (
    [DestinationGuideVersionId]               INT            IDENTITY (1, 1) NOT NULL,
    [Name]                                    NVARCHAR (MAX) NULL,
    [Headline]                                NVARCHAR (MAX) NULL,
    [BodyHtml]                                NVARCHAR (MAX) NULL,
    [MainImage]                               INT            NULL,
    [ParentId]                                INT            NOT NULL,
    [UrlIdentifier]                           NVARCHAR (MAX) NULL,
    [CmsName]                                 NVARCHAR (MAX) NULL,
    [Version]                                 INT            NOT NULL,
    [IsDraft]                                 BIT            NOT NULL,
    [CreatedById]                             INT            NULL,
    [CreatedDate]                             DATETIME2 (7)  NULL,
    [ApprovedById]                            INT            NULL,
    [ApprovedDate]                            DATETIME2 (7)  NULL,
    [PublishedById]                           INT            NULL,
    [PublishedDate]                           DATETIME2 (7)  NULL,
    [UnpublishedById]                         INT            NULL,
    [UnpublishedDate]                         DATETIME2 (7)  NULL,
    [AirportInformation_AirportInformationId] INT            NULL,
    [PageTitle]                               NVARCHAR (MAX) NULL,
    [Keywords]                                NVARCHAR (MAX) NULL,
    [Description]                             NVARCHAR (MAX) NULL,
    [ShowMainImage]                           BIT            NOT NULL
);







