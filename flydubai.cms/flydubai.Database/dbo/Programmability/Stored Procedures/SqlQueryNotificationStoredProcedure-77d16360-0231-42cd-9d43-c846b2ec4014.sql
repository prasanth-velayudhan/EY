﻿CREATE PROCEDURE [SqlQueryNotificationStoredProcedure-77d16360-0231-42cd-9d43-c846b2ec4014] AS BEGIN BEGIN TRANSACTION; RECEIVE TOP(0) conversation_handle FROM [SqlQueryNotificationService-77d16360-0231-42cd-9d43-c846b2ec4014]; IF (SELECT COUNT(*) FROM [SqlQueryNotificationService-77d16360-0231-42cd-9d43-c846b2ec4014] WHERE message_type_name = 'http://schemas.microsoft.com/SQL/ServiceBroker/DialogTimer') > 0 BEGIN if ((SELECT COUNT(*) FROM sys.services WHERE name = 'SqlQueryNotificationService-77d16360-0231-42cd-9d43-c846b2ec4014') > 0)   DROP SERVICE [SqlQueryNotificationService-77d16360-0231-42cd-9d43-c846b2ec4014]; if (OBJECT_ID('SqlQueryNotificationService-77d16360-0231-42cd-9d43-c846b2ec4014', 'SQ') IS NOT NULL)   DROP QUEUE [SqlQueryNotificationService-77d16360-0231-42cd-9d43-c846b2ec4014]; DROP PROCEDURE [SqlQueryNotificationStoredProcedure-77d16360-0231-42cd-9d43-c846b2ec4014]; END COMMIT TRANSACTION; END