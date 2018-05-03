CREATE SERVICE [SqlQueryNotificationService-687f0960-ca15-4962-8ea8-2c5cc22d2a53]
    AUTHORIZATION [WEB2_LIVE_FZ]
    ON QUEUE [dbo].[SqlQueryNotificationService-687f0960-ca15-4962-8ea8-2c5cc22d2a53]
    ([http://schemas.microsoft.com/SQL/Notifications/PostQueryNotification]);

