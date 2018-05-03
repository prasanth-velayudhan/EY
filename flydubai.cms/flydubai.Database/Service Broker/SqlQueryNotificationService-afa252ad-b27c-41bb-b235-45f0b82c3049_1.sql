CREATE SERVICE [SqlQueryNotificationService-afa252ad-b27c-41bb-b235-45f0b82c3049]
    AUTHORIZATION [WEB2_LIVE_FZ]
    ON QUEUE [dbo].[SqlQueryNotificationService-afa252ad-b27c-41bb-b235-45f0b82c3049]
    ([http://schemas.microsoft.com/SQL/Notifications/PostQueryNotification]);

