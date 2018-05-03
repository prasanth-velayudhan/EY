CREATE TABLE [cms].[MailQueue] (
    [MailQueueID]  INT             IDENTITY (1, 1) NOT NULL,
    [Sender]       NVARCHAR (MAX)  NULL,
    [Recipients]   NVARCHAR (MAX)  NULL,
    [Cc]           NVARCHAR (MAX)  NULL,
    [Bcc]          NVARCHAR (MAX)  NULL,
    [Subject]      NVARCHAR (MAX)  NULL,
    [BodyText]     NVARCHAR (MAX)  NULL,
    [BodyHtml]     NVARCHAR (MAX)  NULL,
    [Attachment]   VARBINARY (MAX) NULL,
    [FileName]     NVARCHAR (MAX)  NULL,
    [Failures]     INT             NULL,
    [LastFailure]  DATETIME        NULL,
    [AccountID]    INT             NULL,
    [DateCreated]  DATETIME2 (7)   NOT NULL,
    [CreatedBy]    INT             NOT NULL,
    [DateModified] DATETIME2 (7)   NOT NULL,
    [ModifiedBy]   INT             NOT NULL,
    PRIMARY KEY CLUSTERED ([MailQueueID] ASC)
);

