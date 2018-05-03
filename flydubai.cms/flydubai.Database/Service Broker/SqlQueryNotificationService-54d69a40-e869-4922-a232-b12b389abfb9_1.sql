CREATE SERVICE [SqlQueryNotificationService-54d69a40-e869-4922-a232-b12b389abfb9]
    AUTHORIZATION [WEB2_LIVE_FZ]
    ON QUEUE [dbo].[SqlQueryNotificationService-54d69a40-e869-4922-a232-b12b389abfb9]
    ([http://schemas.microsoft.com/SQL/Notifications/PostQueryNotification]);

