CREATE QUEUE [dbo].[SqlQueryNotificationService-687f0960-ca15-4962-8ea8-2c5cc22d2a53]
    WITH ACTIVATION (STATUS = ON, PROCEDURE_NAME = [dbo].[SqlQueryNotificationStoredProcedure-687f0960-ca15-4962-8ea8-2c5cc22d2a53], MAX_QUEUE_READERS = 1, EXECUTE AS OWNER);

