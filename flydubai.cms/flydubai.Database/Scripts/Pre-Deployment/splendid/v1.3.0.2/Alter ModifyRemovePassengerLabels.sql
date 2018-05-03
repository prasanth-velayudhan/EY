use [flydubai]
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;
GO
SET XACT_ABORT ON;
GO
BEGIN TRANSACTION
GO
ALTER TABLE dbo.ModifyRemovePassengerLabels ADD IFETotalLabelText nvarchar(MAX) NULL
GO
ALTER TABLE dbo.ModifyRemovePassengerLabels SET (LOCK_ESCALATION = TABLE)
GO

UPDATE dbo.ModifyRemovePassengerLabels SET IFETotalLabelText = N'In-flight entertainment' where [Language] = 'en'
GO

UPDATE dbo.ModifyRemovePassengerLabels SET IFETotalLabelText = N'نظام الترفيه على متن الطائرة' where [Language] = 'ar'
GO

COMMIT TRANSACTION;
GO
SET TRANSACTION ISOLATION LEVEL READ COMMITTED;
GO

