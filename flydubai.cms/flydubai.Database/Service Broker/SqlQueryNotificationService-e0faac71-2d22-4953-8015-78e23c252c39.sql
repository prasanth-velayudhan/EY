CREATE QUEUE [dbo].[SqlQueryNotificationService-e0faac71-2d22-4953-8015-78e23c252c39]
    WITH ACTIVATION (STATUS = ON, PROCEDURE_NAME = [dbo].[SqlQueryNotificationStoredProcedure-e0faac71-2d22-4953-8015-78e23c252c39], MAX_QUEUE_READERS = 1, EXECUTE AS OWNER);

