CREATE TABLE [dbo].[ContactSubjectVersions] (
    [ContactSubjectVersionId] INT            IDENTITY (1, 1) NOT NULL,
    [Subject]                 NVARCHAR (MAX) NOT NULL,
    [RecipientEmail]          NVARCHAR (MAX) NOT NULL,
    [ParentId]                INT            NOT NULL,
    [UrlIdentifier]           NVARCHAR (MAX) NULL,
    [CmsName]                 NVARCHAR (MAX) NULL,
    [Version]                 INT            NOT NULL,
    [IsDraft]                 BIT            NOT NULL,
    [CreatedById]             INT            NULL,
    [CreatedDate]             DATETIME2 (7)  NULL,
    [ApprovedById]            INT            NULL,
    [ApprovedDate]            DATETIME2 (7)  NULL,
    [PublishedById]           INT            NULL,
    [PublishedDate]           DATETIME2 (7)  NULL,
    [UnpublishedById]         INT            NULL,
    [UnpublishedDate]         DATETIME2 (7)  NULL,
    PRIMARY KEY CLUSTERED ([ContactSubjectVersionId] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);

