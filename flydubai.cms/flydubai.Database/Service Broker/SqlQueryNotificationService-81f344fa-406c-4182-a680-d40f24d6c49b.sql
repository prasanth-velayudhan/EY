CREATE QUEUE [dbo].[SqlQueryNotificationService-81f344fa-406c-4182-a680-d40f24d6c49b]
    WITH ACTIVATION (STATUS = ON, PROCEDURE_NAME = [dbo].[SqlQueryNotificationStoredProcedure-81f344fa-406c-4182-a680-d40f24d6c49b], MAX_QUEUE_READERS = 1, EXECUTE AS OWNER);

