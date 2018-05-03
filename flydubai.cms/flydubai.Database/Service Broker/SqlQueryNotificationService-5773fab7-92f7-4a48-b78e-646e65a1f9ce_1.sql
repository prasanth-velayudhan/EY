CREATE SERVICE [SqlQueryNotificationService-5773fab7-92f7-4a48-b78e-646e65a1f9ce]
    AUTHORIZATION [WEB2_LIVE_FZ]
    ON QUEUE [dbo].[SqlQueryNotificationService-5773fab7-92f7-4a48-b78e-646e65a1f9ce]
    ([http://schemas.microsoft.com/SQL/Notifications/PostQueryNotification]);

