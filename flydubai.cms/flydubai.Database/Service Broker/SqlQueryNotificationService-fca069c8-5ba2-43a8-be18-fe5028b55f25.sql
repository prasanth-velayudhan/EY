CREATE QUEUE [dbo].[SqlQueryNotificationService-fca069c8-5ba2-43a8-be18-fe5028b55f25]
    WITH ACTIVATION (STATUS = ON, PROCEDURE_NAME = [dbo].[SqlQueryNotificationStoredProcedure-fca069c8-5ba2-43a8-be18-fe5028b55f25], MAX_QUEUE_READERS = 1, EXECUTE AS OWNER);

