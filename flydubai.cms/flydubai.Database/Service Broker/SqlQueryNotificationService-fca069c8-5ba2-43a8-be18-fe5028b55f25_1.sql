CREATE SERVICE [SqlQueryNotificationService-fca069c8-5ba2-43a8-be18-fe5028b55f25]
    AUTHORIZATION [WEB2_LIVE_FZ]
    ON QUEUE [dbo].[SqlQueryNotificationService-fca069c8-5ba2-43a8-be18-fe5028b55f25]
    ([http://schemas.microsoft.com/SQL/Notifications/PostQueryNotification]);

