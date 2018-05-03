CREATE QUEUE [dbo].[SqlQueryNotificationService-54d69a40-e869-4922-a232-b12b389abfb9]
    WITH ACTIVATION (STATUS = ON, PROCEDURE_NAME = [dbo].[SqlQueryNotificationStoredProcedure-54d69a40-e869-4922-a232-b12b389abfb9], MAX_QUEUE_READERS = 1, EXECUTE AS OWNER);

