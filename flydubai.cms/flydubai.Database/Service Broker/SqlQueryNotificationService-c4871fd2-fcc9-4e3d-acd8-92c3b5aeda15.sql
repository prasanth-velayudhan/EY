CREATE QUEUE [dbo].[SqlQueryNotificationService-c4871fd2-fcc9-4e3d-acd8-92c3b5aeda15]
    WITH ACTIVATION (STATUS = ON, PROCEDURE_NAME = [dbo].[SqlQueryNotificationStoredProcedure-c4871fd2-fcc9-4e3d-acd8-92c3b5aeda15], MAX_QUEUE_READERS = 1, EXECUTE AS OWNER);

