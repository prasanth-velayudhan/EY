CREATE SERVICE [SqlQueryNotificationService-ad2ba96d-6a87-46c5-ab45-4c8af86b94a5]
    AUTHORIZATION [WEB2_LIVE_FZ]
    ON QUEUE [dbo].[SqlQueryNotificationService-ad2ba96d-6a87-46c5-ab45-4c8af86b94a5]
    ([http://schemas.microsoft.com/SQL/Notifications/PostQueryNotification]);

