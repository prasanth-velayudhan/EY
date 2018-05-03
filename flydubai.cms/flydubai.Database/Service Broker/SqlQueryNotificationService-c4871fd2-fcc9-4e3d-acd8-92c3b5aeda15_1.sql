CREATE SERVICE [SqlQueryNotificationService-c4871fd2-fcc9-4e3d-acd8-92c3b5aeda15]
    AUTHORIZATION [WEB2_LIVE_FZ]
    ON QUEUE [dbo].[SqlQueryNotificationService-c4871fd2-fcc9-4e3d-acd8-92c3b5aeda15]
    ([http://schemas.microsoft.com/SQL/Notifications/PostQueryNotification]);

