﻿use [flydubai]
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;
GO
SET XACT_ABORT ON;
GO
BEGIN TRANSACTION
GO
ALTER TABLE dbo.GoogleAnalytics ADD  [PaymentAnalytics] nvarchar(MAX) NULL
GO
ALTER TABLE dbo.GoogleAnalytics SET (LOCK_ESCALATION = TABLE)
GO

UPDATE dbo.GoogleAnalytics SET PaymentAnalytics = N' ' 
GO


COMMIT TRANSACTION;
GO
SET TRANSACTION ISOLATION LEVEL READ COMMITTED;
GO