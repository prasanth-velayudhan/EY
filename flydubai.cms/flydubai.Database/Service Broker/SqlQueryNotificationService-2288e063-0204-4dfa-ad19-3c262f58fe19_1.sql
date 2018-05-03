CREATE SERVICE [SqlQueryNotificationService-2288e063-0204-4dfa-ad19-3c262f58fe19]
    AUTHORIZATION [WEB2_LIVE_FZ]
    ON QUEUE [dbo].[SqlQueryNotificationService-2288e063-0204-4dfa-ad19-3c262f58fe19]
    ([http://schemas.microsoft.com/SQL/Notifications/PostQueryNotification]);

