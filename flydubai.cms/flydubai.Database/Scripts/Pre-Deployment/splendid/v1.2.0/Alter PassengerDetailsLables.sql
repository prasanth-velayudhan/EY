use [flydubai]
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;
GO
SET XACT_ABORT ON;
GO
BEGIN TRANSACTION
GO
ALTER TABLE dbo.PassengerDetailsLabels ADD
       InFlightEntertainment                       nvarchar(MAX) NULL,
       AddInFlightEntertainment                    nvarchar(MAX) NULL
GO
ALTER TABLE dbo.PassengerDetailsLabels SET (LOCK_ESCALATION = TABLE)
GO

UPDATE dbo.PassengerDetailsLabels SET InFlightEntertainment  = N'Premium Entertainment Package', AddInFlightEntertainment = N'Add in-flight entertainment' where [Language] = 'en'
GO

UPDATE dbo.PassengerDetailsLabels SET InFlightEntertainment  = N'نظام الترفيه على متن الطائرة', AddInFlightEntertainment = N'إضافة نظام الترفيه على متن الطائرة' where [Language] = 'ar'
GO

COMMIT TRANSACTION;
GO
SET TRANSACTION ISOLATION LEVEL READ COMMITTED;
GO

