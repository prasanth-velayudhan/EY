CREATE QUEUE [dbo].[SqlQueryNotificationService-0455d603-0681-4883-a810-3bfce18a95ba]
    WITH ACTIVATION (STATUS = ON, PROCEDURE_NAME = [dbo].[SqlQueryNotificationStoredProcedure-0455d603-0681-4883-a810-3bfce18a95ba], MAX_QUEUE_READERS = 1, EXECUTE AS OWNER);

