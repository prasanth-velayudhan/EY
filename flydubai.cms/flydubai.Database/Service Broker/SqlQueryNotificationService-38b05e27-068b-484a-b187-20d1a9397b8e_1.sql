CREATE SERVICE [SqlQueryNotificationService-38b05e27-068b-484a-b187-20d1a9397b8e]
    AUTHORIZATION [WEB2_LIVE_FZ]
    ON QUEUE [dbo].[SqlQueryNotificationService-38b05e27-068b-484a-b187-20d1a9397b8e]
    ([http://schemas.microsoft.com/SQL/Notifications/PostQueryNotification]);

