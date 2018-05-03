CREATE QUEUE [dbo].[SqlQueryNotificationService-7c5dfa20-7daa-4b3f-b2c6-58f94080c3ac]
    WITH ACTIVATION (STATUS = ON, PROCEDURE_NAME = [dbo].[SqlQueryNotificationStoredProcedure-7c5dfa20-7daa-4b3f-b2c6-58f94080c3ac], MAX_QUEUE_READERS = 1, EXECUTE AS OWNER);

