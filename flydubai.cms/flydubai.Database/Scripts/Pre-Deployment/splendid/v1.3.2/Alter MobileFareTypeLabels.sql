use [flydubai]
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;
GO
SET XACT_ABORT ON;
GO
BEGIN TRANSACTION
GO
ALTER TABLE dbo.MobileFareTypeLabels ADD  [FortyKgCheckedBaggageAllowance] nvarchar(MAX) NULL
GO
ALTER TABLE dbo.MobileFareTypeLabels SET (LOCK_ESCALATION = TABLE)
GO

UPDATE dbo.MobileFareTypeLabels SET FortyKgCheckedBaggageAllowance = N'Includes 40 kg checked baggage allowance' where [Language] = 'en'
GO

UPDATE dbo.MobileFareTypeLabels SET FortyKgCheckedBaggageAllowance = N'Includes 40 kg checked baggage allowance' where [Language] = 'ar'
GO

COMMIT TRANSACTION;
GO
SET TRANSACTION ISOLATION LEVEL READ COMMITTED;
GO