CREATE QUEUE [dbo].[SqlQueryNotificationService-f3c91a07-62a8-4449-8b4c-e1f99dd768d5]
    WITH ACTIVATION (STATUS = ON, PROCEDURE_NAME = [dbo].[SqlQueryNotificationStoredProcedure-f3c91a07-62a8-4449-8b4c-e1f99dd768d5], MAX_QUEUE_READERS = 1, EXECUTE AS OWNER);

