CREATE QUEUE [dbo].[SqlQueryNotificationService-2288e063-0204-4dfa-ad19-3c262f58fe19]
    WITH ACTIVATION (STATUS = ON, PROCEDURE_NAME = [dbo].[SqlQueryNotificationStoredProcedure-2288e063-0204-4dfa-ad19-3c262f58fe19], MAX_QUEUE_READERS = 1, EXECUTE AS OWNER);

