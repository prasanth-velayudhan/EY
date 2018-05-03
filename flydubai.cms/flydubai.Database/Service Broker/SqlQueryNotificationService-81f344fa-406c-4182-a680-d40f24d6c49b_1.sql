CREATE SERVICE [SqlQueryNotificationService-81f344fa-406c-4182-a680-d40f24d6c49b]
    AUTHORIZATION [WEB2_LIVE_FZ]
    ON QUEUE [dbo].[SqlQueryNotificationService-81f344fa-406c-4182-a680-d40f24d6c49b]
    ([http://schemas.microsoft.com/SQL/Notifications/PostQueryNotification]);

