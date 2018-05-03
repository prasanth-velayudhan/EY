use [flydubai]
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;
GO
SET XACT_ABORT ON;
GO
BEGIN TRANSACTION
GO
ALTER TABLE dbo.InflightEntertainmentLabels ADD  MoviesThisMonth nvarchar(MAX) NULL
GO
ALTER TABLE dbo.InflightEntertainmentLabels SET (LOCK_ESCALATION = TABLE)
GO

UPDATE dbo.InflightEntertainmentLabels SET MoviesThisMonth = N'In-flight entertainment (Movies showing this month)' where [LanguageId] = 1
GO

UPDATE dbo.InflightEntertainmentLabels SET MoviesThisMonth = N'في الترفيه الجوي (أفلام تظهر هذا الشهر)' where [LanguageId] = 2
GO

COMMIT TRANSACTION;
GO
SET TRANSACTION ISOLATION LEVEL READ COMMITTED;
GO