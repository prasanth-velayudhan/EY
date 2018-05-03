CREATE QUEUE [dbo].[SqlQueryNotificationService-d4488967-8418-4462-ad9d-4a6d8d43bcf3]
    WITH ACTIVATION (STATUS = ON, PROCEDURE_NAME = [dbo].[SqlQueryNotificationStoredProcedure-d4488967-8418-4462-ad9d-4a6d8d43bcf3], MAX_QUEUE_READERS = 1, EXECUTE AS OWNER);

