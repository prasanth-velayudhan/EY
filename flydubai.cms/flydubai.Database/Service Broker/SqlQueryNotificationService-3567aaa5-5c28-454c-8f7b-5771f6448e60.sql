CREATE QUEUE [dbo].[SqlQueryNotificationService-3567aaa5-5c28-454c-8f7b-5771f6448e60]
    WITH ACTIVATION (STATUS = ON, PROCEDURE_NAME = [dbo].[SqlQueryNotificationStoredProcedure-3567aaa5-5c28-454c-8f7b-5771f6448e60], MAX_QUEUE_READERS = 1, EXECUTE AS OWNER);

