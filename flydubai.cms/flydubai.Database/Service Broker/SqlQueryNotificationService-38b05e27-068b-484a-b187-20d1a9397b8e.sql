CREATE QUEUE [dbo].[SqlQueryNotificationService-38b05e27-068b-484a-b187-20d1a9397b8e]
    WITH ACTIVATION (STATUS = ON, PROCEDURE_NAME = [dbo].[SqlQueryNotificationStoredProcedure-38b05e27-068b-484a-b187-20d1a9397b8e], MAX_QUEUE_READERS = 1, EXECUTE AS OWNER);

