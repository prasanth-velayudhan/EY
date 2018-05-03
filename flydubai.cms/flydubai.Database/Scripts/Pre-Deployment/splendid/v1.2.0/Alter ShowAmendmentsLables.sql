use [flydubai]
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;
GO
SET XACT_ABORT ON;
GO
BEGIN TRANSACTION
GO
ALTER TABLE dbo.ShowAmendmentsLabels ADD
       InFlightEntertainmentLabelText nvarchar(MAX) NULL,
       OptionalExtras nvarchar(MAX) NULL
GO
ALTER TABLE dbo.ShowAmendmentsLabels SET (LOCK_ESCALATION = TABLE)
GO

UPDATE dbo.ShowAmendmentsLabels SET InFlightEntertainmentLabelText  = N'In-flight entertainment', OptionalExtras = N'Optional Extras' where [Language] = 'en'
GO

UPDATE dbo.ShowAmendmentsLabels SET InFlightEntertainmentLabelText  = N'نظام الترفيه على متن الطائرة', OptionalExtras = N'الإضافات الإختيارية' where [Language] = 'ar'
GO

COMMIT TRANSACTION;
GO
SET TRANSACTION ISOLATION LEVEL READ COMMITTED;
GO
