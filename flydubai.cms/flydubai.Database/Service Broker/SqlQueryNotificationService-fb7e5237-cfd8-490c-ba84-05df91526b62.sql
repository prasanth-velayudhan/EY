CREATE QUEUE [dbo].[SqlQueryNotificationService-fb7e5237-cfd8-490c-ba84-05df91526b62]
    WITH ACTIVATION (STATUS = ON, PROCEDURE_NAME = [dbo].[SqlQueryNotificationStoredProcedure-fb7e5237-cfd8-490c-ba84-05df91526b62], MAX_QUEUE_READERS = 1, EXECUTE AS OWNER);

