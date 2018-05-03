use [flydubai]
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;
GO
SET XACT_ABORT ON;
GO
BEGIN TRANSACTION
GO
ALTER TABLE dbo.BookingLabels ADD
       OptionalExtras                           nvarchar(MAX) NULL,
       InFlightEntertainment                    nvarchar(MAX) NULL,
       InFlightEntertainmentPackageDescription  nvarchar(MAX) NULL,
       NoInFlightEntertainment                  nvarchar(MAX) NULL
GO
ALTER TABLE dbo.BookingLabels SET (LOCK_ESCALATION = TABLE)
GO

UPDATE dbo.BookingLabels SET OptionalExtras = N'Optional Extras', InFlightEntertainment  = N'In-flight entertainment', InFlightEntertainmentPackageDescription = N'Premium in-flight entertainment package', NoInFlightEntertainment= N'Buy on board, if available.' where [Language] = 'en'
GO

UPDATE dbo.BookingLabels SET OptionalExtras = N'الإضافات الإختيارية', InFlightEntertainment  = N'نظام الترفيه على متن الطائرة', InFlightEntertainmentPackageDescription = N'حزمة الترفيه المميزة', NoInFlightEntertainment= N'الشراء على متن الطائرة، إن وجد.' where [Language] = 'ar'
GO

COMMIT TRANSACTION;
GO
SET TRANSACTION ISOLATION LEVEL READ COMMITTED;
GO
