use [flydubai]
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;
GO
SET XACT_ABORT ON;
GO
BEGIN TRANSACTION
GO
ALTER TABLE dbo.BookingLabels ADD
       InFlightEntertainmentUnavailable nvarchar(MAX) NULL
GO
ALTER TABLE dbo.BookingLabels SET (LOCK_ESCALATION = TABLE)
GO

UPDATE dbo.BookingLabels SET InFlightEntertainmentUnavailable = N'Unavailable.' where [Language] = 'en'
GO

UPDATE dbo.BookingLabels SET InFlightEntertainmentUnavailable = N'غير متاح' where [Language] = 'ar'
GO

COMMIT TRANSACTION;
GO
SET TRANSACTION ISOLATION LEVEL READ COMMITTED;
GO
