CREATE SERVICE [SqlQueryNotificationService-2377fd26-57c6-4169-9ddf-f3972a5e8dc2]
    AUTHORIZATION [WEB2_LIVE_FZ]
    ON QUEUE [dbo].[SqlQueryNotificationService-2377fd26-57c6-4169-9ddf-f3972a5e8dc2]
    ([http://schemas.microsoft.com/SQL/Notifications/PostQueryNotification]);

