CREATE SERVICE [SqlQueryNotificationService-e0faac71-2d22-4953-8015-78e23c252c39]
    AUTHORIZATION [WEB2_LIVE_FZ]
    ON QUEUE [dbo].[SqlQueryNotificationService-e0faac71-2d22-4953-8015-78e23c252c39]
    ([http://schemas.microsoft.com/SQL/Notifications/PostQueryNotification]);

