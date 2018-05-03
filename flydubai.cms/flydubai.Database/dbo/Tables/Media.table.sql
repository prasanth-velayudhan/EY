CREATE TABLE [dbo].[Media] (
    [MediaId]          INT            IDENTITY (1, 1) NOT NULL,
    [MediaCategoryId]  INT            NULL,
    [Name]             NVARCHAR (MAX) NULL,
    [FileName]         NVARCHAR (MAX) NULL,
    [DownloadFileName] NVARCHAR (MAX) NULL,
    [FileSize]         INT            NOT NULL,
    [IsImage]          BIT            NOT NULL,
    [ImageWidth]       INT            NULL,
    [ImageHeight]      INT            NULL,
    [IsDeleted]        BIT            NOT NULL,
    [CreatedBy]        INT            NULL,
    [CreatedDate]      DATETIME2 (7)  NULL,
    [LastModifiedBy]   INT            NULL,
    [LastModifiedDate] DATETIME2 (7)  NULL,
    [DeletedBy]        INT            NULL,
    [DeletedDate]      DATETIME2 (7)  NULL,
    PRIMARY KEY CLUSTERED ([MediaId] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);

