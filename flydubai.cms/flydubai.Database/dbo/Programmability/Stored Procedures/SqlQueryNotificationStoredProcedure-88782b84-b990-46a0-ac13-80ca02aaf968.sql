﻿CREATE PROCEDURE [SqlQueryNotificationStoredProcedure-88782b84-b990-46a0-ac13-80ca02aaf968] AS BEGIN BEGIN TRANSACTION; RECEIVE TOP(0) conversation_handle FROM [SqlQueryNotificationService-88782b84-b990-46a0-ac13-80ca02aaf968]; IF (SELECT COUNT(*) FROM [SqlQueryNotificationService-88782b84-b990-46a0-ac13-80ca02aaf968] WHERE message_type_name = 'http://schemas.microsoft.com/SQL/ServiceBroker/DialogTimer') > 0 BEGIN if ((SELECT COUNT(*) FROM sys.services WHERE name = 'SqlQueryNotificationService-88782b84-b990-46a0-ac13-80ca02aaf968') > 0)   DROP SERVICE [SqlQueryNotificationService-88782b84-b990-46a0-ac13-80ca02aaf968]; if (OBJECT_ID('SqlQueryNotificationService-88782b84-b990-46a0-ac13-80ca02aaf968', 'SQ') IS NOT NULL)   DROP QUEUE [SqlQueryNotificationService-88782b84-b990-46a0-ac13-80ca02aaf968]; DROP PROCEDURE [SqlQueryNotificationStoredProcedure-88782b84-b990-46a0-ac13-80ca02aaf968]; END COMMIT TRANSACTION; END