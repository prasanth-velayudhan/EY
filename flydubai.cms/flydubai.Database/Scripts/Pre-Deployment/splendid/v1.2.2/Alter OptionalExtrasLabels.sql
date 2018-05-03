use [flydubai]
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;
GO
SET XACT_ABORT ON;
GO
BEGIN TRANSACTION
GO
ALTER TABLE dbo.OptionalExtrasLabels ADD
        IFENotForSaleOnThisFlight nvarchar(MAX) NULL
GO
ALTER TABLE dbo.OptionalExtrasLabels SET (LOCK_ESCALATION = TABLE)
GO

UPDATE dbo.OptionalExtrasLabels SET IFENotForSaleOnThisFlight = N'Unavailable.'  where [Language] = 'en'
GO

UPDATE dbo.OptionalExtrasLabels SET IFENotForSaleOnThisFlight = N'غير متاح'  where [Language] = 'ar'
GO
COMMIT TRANSACTION;
GO
SET TRANSACTION ISOLATION LEVEL READ COMMITTED;
GO
