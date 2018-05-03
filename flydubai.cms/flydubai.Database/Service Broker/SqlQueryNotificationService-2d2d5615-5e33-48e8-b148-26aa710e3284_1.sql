CREATE SERVICE [SqlQueryNotificationService-2d2d5615-5e33-48e8-b148-26aa710e3284]
    AUTHORIZATION [WEB2_LIVE_FZ]
    ON QUEUE [dbo].[SqlQueryNotificationService-2d2d5615-5e33-48e8-b148-26aa710e3284]
    ([http://schemas.microsoft.com/SQL/Notifications/PostQueryNotification]);

