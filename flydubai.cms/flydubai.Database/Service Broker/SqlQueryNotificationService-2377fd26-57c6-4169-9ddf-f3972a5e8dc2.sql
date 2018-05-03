CREATE QUEUE [dbo].[SqlQueryNotificationService-2377fd26-57c6-4169-9ddf-f3972a5e8dc2]
    WITH ACTIVATION (STATUS = ON, PROCEDURE_NAME = [dbo].[SqlQueryNotificationStoredProcedure-2377fd26-57c6-4169-9ddf-f3972a5e8dc2], MAX_QUEUE_READERS = 1, EXECUTE AS OWNER);

