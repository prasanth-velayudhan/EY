CREATE SERVICE [SqlQueryNotificationService-a6dec2bf-b6b1-49fd-8399-0f5592c3f54d]
    AUTHORIZATION [WEB2_LIVE_FZ]
    ON QUEUE [dbo].[SqlQueryNotificationService-a6dec2bf-b6b1-49fd-8399-0f5592c3f54d]
    ([http://schemas.microsoft.com/SQL/Notifications/PostQueryNotification]);

