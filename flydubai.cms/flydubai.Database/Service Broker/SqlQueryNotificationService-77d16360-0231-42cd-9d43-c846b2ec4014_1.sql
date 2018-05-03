CREATE SERVICE [SqlQueryNotificationService-77d16360-0231-42cd-9d43-c846b2ec4014]
    AUTHORIZATION [WEB2_LIVE_FZ]
    ON QUEUE [dbo].[SqlQueryNotificationService-77d16360-0231-42cd-9d43-c846b2ec4014]
    ([http://schemas.microsoft.com/SQL/Notifications/PostQueryNotification]);

