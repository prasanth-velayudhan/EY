CREATE SERVICE [SqlQueryNotificationService-3567aaa5-5c28-454c-8f7b-5771f6448e60]
    AUTHORIZATION [WEB2_LIVE_FZ]
    ON QUEUE [dbo].[SqlQueryNotificationService-3567aaa5-5c28-454c-8f7b-5771f6448e60]
    ([http://schemas.microsoft.com/SQL/Notifications/PostQueryNotification]);

