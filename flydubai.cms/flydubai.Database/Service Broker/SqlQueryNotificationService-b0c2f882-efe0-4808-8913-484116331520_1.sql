CREATE SERVICE [SqlQueryNotificationService-b0c2f882-efe0-4808-8913-484116331520]
    AUTHORIZATION [WEB2_LIVE_FZ]
    ON QUEUE [dbo].[SqlQueryNotificationService-b0c2f882-efe0-4808-8913-484116331520]
    ([http://schemas.microsoft.com/SQL/Notifications/PostQueryNotification]);

