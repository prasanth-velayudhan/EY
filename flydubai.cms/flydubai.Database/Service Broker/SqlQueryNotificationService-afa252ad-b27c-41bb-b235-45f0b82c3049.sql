CREATE QUEUE [dbo].[SqlQueryNotificationService-afa252ad-b27c-41bb-b235-45f0b82c3049]
    WITH ACTIVATION (STATUS = ON, PROCEDURE_NAME = [dbo].[SqlQueryNotificationStoredProcedure-afa252ad-b27c-41bb-b235-45f0b82c3049], MAX_QUEUE_READERS = 1, EXECUTE AS OWNER);

