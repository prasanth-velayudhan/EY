CREATE QUEUE [dbo].[SqlQueryNotificationService-a6dec2bf-b6b1-49fd-8399-0f5592c3f54d]
    WITH ACTIVATION (STATUS = ON, PROCEDURE_NAME = [dbo].[SqlQueryNotificationStoredProcedure-a6dec2bf-b6b1-49fd-8399-0f5592c3f54d], MAX_QUEUE_READERS = 1, EXECUTE AS OWNER);

