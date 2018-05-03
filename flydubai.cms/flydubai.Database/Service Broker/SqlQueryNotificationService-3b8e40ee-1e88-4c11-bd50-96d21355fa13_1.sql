CREATE SERVICE [SqlQueryNotificationService-3b8e40ee-1e88-4c11-bd50-96d21355fa13]
    AUTHORIZATION [WEB2_LIVE_FZ]
    ON QUEUE [dbo].[SqlQueryNotificationService-3b8e40ee-1e88-4c11-bd50-96d21355fa13]
    ([http://schemas.microsoft.com/SQL/Notifications/PostQueryNotification]);

