CREATE SERVICE [SqlQueryNotificationService-d4488967-8418-4462-ad9d-4a6d8d43bcf3]
    AUTHORIZATION [WEB2_LIVE_FZ]
    ON QUEUE [dbo].[SqlQueryNotificationService-d4488967-8418-4462-ad9d-4a6d8d43bcf3]
    ([http://schemas.microsoft.com/SQL/Notifications/PostQueryNotification]);

