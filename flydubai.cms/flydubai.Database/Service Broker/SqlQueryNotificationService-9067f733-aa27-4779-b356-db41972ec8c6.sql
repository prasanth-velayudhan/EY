CREATE QUEUE [dbo].[SqlQueryNotificationService-9067f733-aa27-4779-b356-db41972ec8c6]
    WITH ACTIVATION (STATUS = ON, PROCEDURE_NAME = [dbo].[SqlQueryNotificationStoredProcedure-9067f733-aa27-4779-b356-db41972ec8c6], MAX_QUEUE_READERS = 1, EXECUTE AS OWNER);

