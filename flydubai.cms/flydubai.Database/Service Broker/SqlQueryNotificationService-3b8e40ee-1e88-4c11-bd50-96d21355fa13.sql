CREATE QUEUE [dbo].[SqlQueryNotificationService-3b8e40ee-1e88-4c11-bd50-96d21355fa13]
    WITH ACTIVATION (STATUS = ON, PROCEDURE_NAME = [dbo].[SqlQueryNotificationStoredProcedure-3b8e40ee-1e88-4c11-bd50-96d21355fa13], MAX_QUEUE_READERS = 1, EXECUTE AS OWNER);

