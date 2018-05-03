CREATE SERVICE [SqlQueryNotificationService-f3c91a07-62a8-4449-8b4c-e1f99dd768d5]
    AUTHORIZATION [WEB2_LIVE_FZ]
    ON QUEUE [dbo].[SqlQueryNotificationService-f3c91a07-62a8-4449-8b4c-e1f99dd768d5]
    ([http://schemas.microsoft.com/SQL/Notifications/PostQueryNotification]);

