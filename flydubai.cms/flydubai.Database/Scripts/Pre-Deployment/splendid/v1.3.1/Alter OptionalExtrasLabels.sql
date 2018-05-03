use [flydubai]
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;
GO
SET XACT_ABORT ON;
GO
BEGIN TRANSACTION
GO
ALTER TABLE dbo.OptionalExtrasLabels ADD ViewThisMonthMovies nvarchar(MAX) NULL
GO
ALTER TABLE dbo.OptionalExtrasLabels SET (LOCK_ESCALATION = TABLE)
GO

UPDATE dbo.OptionalExtrasLabels SET ViewThisMonthMovies = N'View movies showing this month'  where [Language] = 'en'
GO

UPDATE dbo.OptionalExtrasLabels SET ViewThisMonthMovies = N'عرض أفلام تظهر هذا الشهر' where [Language] = 'ar'
GO
COMMIT TRANSACTION;
GO
SET TRANSACTION ISOLATION LEVEL READ COMMITTED;
GO