CREATE QUEUE [dbo].[SqlQueryNotificationService-56afb320-7457-46df-b1a8-aadeca528b21]
    WITH ACTIVATION (STATUS = ON, PROCEDURE_NAME = [dbo].[SqlQueryNotificationStoredProcedure-56afb320-7457-46df-b1a8-aadeca528b21], MAX_QUEUE_READERS = 1, EXECUTE AS OWNER);

