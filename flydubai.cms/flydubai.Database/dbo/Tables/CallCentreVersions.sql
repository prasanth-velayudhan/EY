CREATE TABLE [dbo].[CallCentreVersions] (
    [CallCentreVersionId] INT            IDENTITY (1, 1) NOT NULL,
    [CountryId]           INT            NOT NULL,
    [Telephone]           NVARCHAR (MAX) NULL,
    [ParentId]            INT            NOT NULL,
    [UrlIdentifier]       NVARCHAR (MAX) NULL,
    [CmsName]             NVARCHAR (MAX) NULL,
    [Version]             INT            NOT NULL,
    [IsDraft]             BIT            NOT NULL,
    [CreatedById]         INT            NULL,
    [CreatedDate]         DATETIME2 (7)  NULL,
    [ApprovedById]        INT            NULL,
    [ApprovedDate]        DATETIME2 (7)  NULL,
    [PublishedById]       INT            NULL,
    [PublishedDate]       DATETIME2 (7)  NULL,
    [UnpublishedById]     INT            NULL,
    [UnpublishedDate]     DATETIME2 (7)  NULL
);



