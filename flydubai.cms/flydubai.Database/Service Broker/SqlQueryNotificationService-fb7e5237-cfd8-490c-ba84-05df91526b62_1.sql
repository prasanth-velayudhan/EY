CREATE SERVICE [SqlQueryNotificationService-fb7e5237-cfd8-490c-ba84-05df91526b62]
    AUTHORIZATION [WEB2_LIVE_FZ]
    ON QUEUE [dbo].[SqlQueryNotificationService-fb7e5237-cfd8-490c-ba84-05df91526b62]
    ([http://schemas.microsoft.com/SQL/Notifications/PostQueryNotification]);

