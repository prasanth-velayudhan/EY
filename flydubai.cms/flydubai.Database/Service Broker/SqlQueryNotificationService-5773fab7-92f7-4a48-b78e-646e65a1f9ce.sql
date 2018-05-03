CREATE QUEUE [dbo].[SqlQueryNotificationService-5773fab7-92f7-4a48-b78e-646e65a1f9ce]
    WITH ACTIVATION (STATUS = ON, PROCEDURE_NAME = [dbo].[SqlQueryNotificationStoredProcedure-5773fab7-92f7-4a48-b78e-646e65a1f9ce], MAX_QUEUE_READERS = 1, EXECUTE AS OWNER);

