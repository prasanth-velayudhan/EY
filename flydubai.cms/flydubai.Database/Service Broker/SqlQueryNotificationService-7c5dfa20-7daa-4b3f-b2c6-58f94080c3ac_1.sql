CREATE SERVICE [SqlQueryNotificationService-7c5dfa20-7daa-4b3f-b2c6-58f94080c3ac]
    AUTHORIZATION [WEB2_LIVE_FZ]
    ON QUEUE [dbo].[SqlQueryNotificationService-7c5dfa20-7daa-4b3f-b2c6-58f94080c3ac]
    ([http://schemas.microsoft.com/SQL/Notifications/PostQueryNotification]);

