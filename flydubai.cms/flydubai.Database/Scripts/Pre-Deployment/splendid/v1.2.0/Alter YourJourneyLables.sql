use [flydubai]
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;
GO
SET XACT_ABORT ON;
GO
BEGIN TRANSACTION
GO
ALTER TABLE dbo.YourJourneyLabels ADD InFlightEntertainment nvarchar(MAX) NULL, PurchasedInFlightEntertainment nvarchar(MAX) NULL
GO
ALTER TABLE dbo.YourJourneyLabels SET (LOCK_ESCALATION = TABLE)
GO

UPDATE dbo.YourJourneyLabels SET InFlightEntertainment = N'In-flight entertainment', PurchasedInFlightEntertainment = N'Premium IFE' where [Language] = 'en'
GO

UPDATE dbo.YourJourneyLabels SET InFlightEntertainment = N'نظام الترفيه على متن الطائرة', PurchasedInFlightEntertainment = N'العرض الممتاز' where [Language] = 'ar'
GO

COMMIT TRANSACTION;
GO
SET TRANSACTION ISOLATION LEVEL READ COMMITTED;
GO