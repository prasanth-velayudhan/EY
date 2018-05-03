CREATE QUEUE [dbo].[SqlQueryNotificationService-88782b84-b990-46a0-ac13-80ca02aaf968]
    WITH ACTIVATION (STATUS = ON, PROCEDURE_NAME = [dbo].[SqlQueryNotificationStoredProcedure-88782b84-b990-46a0-ac13-80ca02aaf968], MAX_QUEUE_READERS = 1, EXECUTE AS OWNER);

