CREATE QUEUE [dbo].[SqlQueryNotificationService-438cd11f-5155-4414-adea-1e711bf76f69]
    WITH ACTIVATION (STATUS = ON, PROCEDURE_NAME = [dbo].[SqlQueryNotificationStoredProcedure-438cd11f-5155-4414-adea-1e711bf76f69], MAX_QUEUE_READERS = 1, EXECUTE AS OWNER);

