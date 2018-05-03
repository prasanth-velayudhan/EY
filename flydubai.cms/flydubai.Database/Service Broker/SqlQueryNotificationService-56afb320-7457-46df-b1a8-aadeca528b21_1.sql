CREATE SERVICE [SqlQueryNotificationService-56afb320-7457-46df-b1a8-aadeca528b21]
    AUTHORIZATION [WEB2_LIVE_FZ]
    ON QUEUE [dbo].[SqlQueryNotificationService-56afb320-7457-46df-b1a8-aadeca528b21]
    ([http://schemas.microsoft.com/SQL/Notifications/PostQueryNotification]);

