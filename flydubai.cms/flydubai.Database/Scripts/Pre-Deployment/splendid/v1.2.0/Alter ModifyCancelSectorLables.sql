use [flydubai]
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;
GO
SET XACT_ABORT ON;
GO
BEGIN TRANSACTION
GO
ALTER TABLE dbo.ModifyCancelSectorLabels ADD
       IFELabelText                      nvarchar(MAX) NULL
GO
ALTER TABLE dbo.ModifyCancelSectorLabels SET (LOCK_ESCALATION = TABLE)
GO

UPDATE dbo.ModifyCancelSectorLabels SET IFELabelText = N'In Flight Entertainment' where [Language] = 'en'
GO

UPDATE dbo.ModifyCancelSectorLabels SET IFELabelText = N'Iنظام الترفيه على متن الطائرة' where [Language]= 'ar'
GO
COMMIT TRANSACTION;
GO
SET TRANSACTION ISOLATION LEVEL READ COMMITTED;
GO
