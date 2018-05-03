CREATE SERVICE [SqlQueryNotificationService-88782b84-b990-46a0-ac13-80ca02aaf968]
    AUTHORIZATION [WEB2_LIVE_FZ]
    ON QUEUE [dbo].[SqlQueryNotificationService-88782b84-b990-46a0-ac13-80ca02aaf968]
    ([http://schemas.microsoft.com/SQL/Notifications/PostQueryNotification]);

