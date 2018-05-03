CREATE SERVICE [SqlQueryNotificationService-7a122bb9-e14c-41cd-886e-d0edc36e7795]
    AUTHORIZATION [WEB2_LIVE_FZ]
    ON QUEUE [dbo].[SqlQueryNotificationService-7a122bb9-e14c-41cd-886e-d0edc36e7795]
    ([http://schemas.microsoft.com/SQL/Notifications/PostQueryNotification]);

