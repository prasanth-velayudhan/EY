CREATE TABLE [dbo].[AiportUpdatedDateTimes] (
    [Id]                     INT      IDENTITY (1, 1) NOT NULL,
    [UpdatedRefreshDateTime] DATETIME NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
CREATE TRIGGER dbo.[AiportUpdatedDateTimes_AspNet_SqlCacheNotification_Trigger] ON [AiportUpdatedDateTimes]
                       FOR INSERT, UPDATE, DELETE AS BEGIN
                       SET NOCOUNT ON
                       EXEC dbo.AspNet_SqlCacheUpdateChangeIdStoredProcedure N'AiportUpdatedDateTimes'
                       END