CREATE TABLE [dbo].[GlobalPRContactVersions] (
    [GlobalPRContactVersionId] INT            IDENTITY (1, 1) NOT NULL,
    [Location]                 NVARCHAR (MAX) NOT NULL,
    [Email]                    NVARCHAR (MAX) NULL,
    [Telephone]                NVARCHAR (MAX) NULL,
    [TelephoneContactHours]    NVARCHAR (MAX) NULL,
    [ParentId]                 INT            NOT NULL,
    [UrlIdentifier]            NVARCHAR (MAX) NULL,
    [CmsName]                  NVARCHAR (MAX) NULL,
    [Version]                  INT            NOT NULL,
    [IsDraft]                  BIT            NOT NULL,
    [CreatedById]              INT            NULL,
    [CreatedDate]              DATETIME2 (7)  NULL,
    [ApprovedById]             INT            NULL,
    [ApprovedDate]             DATETIME2 (7)  NULL,
    [PublishedById]            INT            NULL,
    [PublishedDate]            DATETIME2 (7)  NULL,
    [UnpublishedById]          INT            NULL,
    [UnpublishedDate]          DATETIME2 (7)  NULL,
    [ContactName]              NVARCHAR (MAX) NULL,
    [ContactDetails]           NVARCHAR (MAX) DEFAULT ('') NOT NULL,
    [Designation]              NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([GlobalPRContactVersionId] ASC)
);



