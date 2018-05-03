CREATE QUEUE [dbo].[SqlQueryNotificationService-ad2ba96d-6a87-46c5-ab45-4c8af86b94a5]
    WITH ACTIVATION (STATUS = ON, PROCEDURE_NAME = [dbo].[SqlQueryNotificationStoredProcedure-ad2ba96d-6a87-46c5-ab45-4c8af86b94a5], MAX_QUEUE_READERS = 1, EXECUTE AS OWNER);

