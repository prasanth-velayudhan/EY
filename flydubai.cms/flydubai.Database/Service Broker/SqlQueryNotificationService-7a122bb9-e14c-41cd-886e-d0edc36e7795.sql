CREATE QUEUE [dbo].[SqlQueryNotificationService-7a122bb9-e14c-41cd-886e-d0edc36e7795]
    WITH ACTIVATION (STATUS = ON, PROCEDURE_NAME = [dbo].[SqlQueryNotificationStoredProcedure-7a122bb9-e14c-41cd-886e-d0edc36e7795], MAX_QUEUE_READERS = 1, EXECUTE AS OWNER);

