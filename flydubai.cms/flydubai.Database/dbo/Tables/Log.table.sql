CREATE TABLE [dbo].[Log] (
    [Id]                     INT             IDENTITY (1, 1) NOT NULL,
    [ExceptionKey]           NVARCHAR (50)   NULL,
    [Date]                   DATETIME        NULL,
    [Level]                  NVARCHAR (50)   NULL,
    [URL]                    NVARCHAR (200)  NULL,
    [Operation]              NVARCHAR (500)  NULL,
    [RadixxExceptionCode]    NVARCHAR (50)   NULL,
    [RadixxExceptionSource]  NVARCHAR (4000) NULL,
    [Request]                NVARCHAR (4000) NULL,
    [SecurityGuid]           NVARCHAR (50)   NULL,
    [Message]                NVARCHAR (4000) NULL,
    [Exception]              NVARCHAR (4000) NULL,
    [ProfileType]            NVARCHAR (50)   NULL,
    [ProfileId]              NVARCHAR (50)   NULL,
    [Email]                  NVARCHAR (50)   NULL,
    [ServerName]             NVARCHAR (50)   NULL,
    [PNR]                    NVARCHAR (10)   NULL,
    [WcfServiceName]         NVARCHAR (100)  NULL,
    [WcfServiceTotalSeconds] NVARCHAR (10)   NULL,
    [PageName]               NVARCHAR (MAX)  NULL,
    [Response]               NVARCHAR (MAX)  NULL,
    [ClientIPAddress]        NVARCHAR (MAX)  NULL,
    [ErrorCode]              NVARCHAR (MAX)  NULL,
    [IATA]                   NVARCHAR (MAX)  NULL
);






GO
CREATE NONCLUSTERED INDEX [ix_session_id]
    ON [dbo].[Log]([SecurityGuid] ASC);


GO
CREATE NONCLUSTERED INDEX [ix_date]
    ON [dbo].[Log]([Date] ASC);


GO
CREATE NONCLUSTERED INDEX [idx_log_id]
    ON [dbo].[Log]([Id] ASC);

