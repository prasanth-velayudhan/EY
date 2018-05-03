CREATE SERVICE [SqlQueryNotificationService-9067f733-aa27-4779-b356-db41972ec8c6]
    AUTHORIZATION [WEB2_LIVE_FZ]
    ON QUEUE [dbo].[SqlQueryNotificationService-9067f733-aa27-4779-b356-db41972ec8c6]
    ([http://schemas.microsoft.com/SQL/Notifications/PostQueryNotification]);

