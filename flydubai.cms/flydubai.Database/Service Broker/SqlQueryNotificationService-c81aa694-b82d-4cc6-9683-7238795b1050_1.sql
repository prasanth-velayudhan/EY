CREATE SERVICE [SqlQueryNotificationService-c81aa694-b82d-4cc6-9683-7238795b1050]
    AUTHORIZATION [WEB2_LIVE_FZ]
    ON QUEUE [dbo].[SqlQueryNotificationService-c81aa694-b82d-4cc6-9683-7238795b1050]
    ([http://schemas.microsoft.com/SQL/Notifications/PostQueryNotification]);

