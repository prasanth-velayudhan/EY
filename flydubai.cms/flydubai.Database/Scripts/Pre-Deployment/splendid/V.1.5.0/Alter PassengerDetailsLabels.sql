use [flydubai]
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;
GO
SET XACT_ABORT ON;
GO
BEGIN TRANSACTION
GO
ALTER TABLE dbo.PassengerDetailsLabels ADD  Russian nvarchar(MAX) NULL
GO
ALTER TABLE dbo.PassengerDetailsLabels SET (LOCK_ESCALATION = TABLE)
GO

UPDATE dbo.PassengerDetailsLabels SET Russian  = N'Russian' where [Language] = 'en'
GO

UPDATE dbo.PassengerDetailsLabels SET Russian  = N'الروسية' where [Language] = 'ar'
GO

UPDATE dbo.PassengerDetailsLabels SET Russian  = N'русский' where [Language] = 'ru'
GO

COMMIT TRANSACTION;
GO
SET TRANSACTION ISOLATION LEVEL READ COMMITTED;
GO

